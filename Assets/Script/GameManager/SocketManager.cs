using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using UnityEngine;

public class SocketManager 
{
    private UdpSocket udpSocket;
    private string host = "127.0.0.1";
    private int hostPort = 9999;
    private Thread receiveThread;
    private int clientPort = UnityEngine.Random.Range(100, 1000);
    private Queue<Action> mainThreadExecutionQueue = new Queue<Action>();
    public SocketManager()
    {
        udpSocket = new UdpSocket(clientPort);
        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();

    }

    public void SendAsync(string message)
    {
        udpSocket.SendAsync(message, host, hostPort);
    }

    private void ReceiveData()
    {
        IPAddress serverAddress = IPAddress.Parse(host);
        IPEndPoint hostIP = new IPEndPoint(serverAddress, hostPort);
        while (true)
        {
            byte[] data = udpSocket.socket.Receive(ref hostIP);  // anyIP is reused in each iteration
            string message = Encoding.UTF8.GetString(data);
            lock(mainThreadExecutionQueue)
            {
                mainThreadExecutionQueue.Enqueue(() => ProcessMessage(message));
            }
        }
    }

    public void FixedUpdate()
    {
        lock(mainThreadExecutionQueue)
        {
            while (mainThreadExecutionQueue.Count > 0)
            {
                mainThreadExecutionQueue.Dequeue().Invoke();
            }
        }
    }

    private void ProcessMessage(string message)
    {
        Debug.Log(message);
    }
}
