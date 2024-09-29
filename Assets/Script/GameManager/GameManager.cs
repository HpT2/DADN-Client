using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public MapManager mapManager;
    public EnemyManager enemyManager;
    public SocketManager socketManager;
    public static GameManager instance;
    public int frame = 0;
    public enum GameState
    {
        menu,
        room,
        game
    }
    public GameState state;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        state = GameState.menu;
        playerManager = new PlayerManager();
        mapManager = new MapManager();
        enemyManager = new EnemyManager();
        socketManager = new SocketManager();
    }


    private void FixedUpdate()
    {
        socketManager.FixedUpdate();
        playerManager.FixedUpdate();
        enemyManager.FixedUpdate();

        if (frame % 3 == 0)
        {
            //Test sending
            SendFormat<Test> data = new SendFormat<Test>(new Test());
            socketManager.SendAsync(JsonUtility.ToJson(data));
        }
        frame++;
    }

    private void LateUpdate()
    {
        playerManager.LateUpdate();
        enemyManager.LateUpdate();
    }
}
