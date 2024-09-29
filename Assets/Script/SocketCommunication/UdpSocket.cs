using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class UdpSocket
{
    public UdpClient socket;
   
    public async void SendAsync(string message, string host, int port)
    {
        byte[] data = Encoding.UTF8.GetBytes(message);
        await socket.SendAsync(data, data.Length, host, port);
    }

    public UdpSocket(int port)
    {
        socket = new UdpClient(port);
    }
}
