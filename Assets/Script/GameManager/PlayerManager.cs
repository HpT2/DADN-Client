using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager 
{
    public Dictionary<string, Player> playersDict;

    public PlayerManager()
    {
        playersDict = new Dictionary<string, Player>();
    }

    public void FixedUpdate()
    {
        foreach(var player in playersDict.Values)
        {
            player.FixedUpdate();
        }
    }

    public void LateUpdate()
    {

    }
}
