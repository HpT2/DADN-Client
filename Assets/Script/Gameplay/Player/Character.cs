using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public CharacterConfig config;
    public GameObject characterObj;
    public void Apply(CharacterConfig newConfig, Player player)
    {
        Vector3 currentPos = Vector3.zero;
        if (config != null)
        {
            currentPos = characterObj.transform.position;
            GameObject.Destroy(characterObj);
        }
        characterObj = GameObject.Instantiate(newConfig.characterPrefab);
        characterObj.transform.position = currentPos;

        config = newConfig;
        string statStr = JsonUtility.ToJson(config.stats);
        player.totalStats = JsonUtility.FromJson<Stats>(statStr);
        
        //player.totalStats.atk = newConfig.stats.atk;
        //player.totalStats.atkRange = newConfig.stats.atkRange;  
        //player.totalStats.atkSpd = newConfig.stats.atkSpd;
        //player.totalStats.maxHP = newConfig.stats.maxHP;
        //player.totalStats.moveSpd = newConfig.stats.moveSpd;
        //player.totalStats.def = newConfig.stats.def;
        //player.totalStats.expGain = newConfig.stats.expGain;
        //player.totalStats.critRate = newConfig.stats.critRate;
        //player.totalStats.critDmg = newConfig.stats.critDmg;
    }
}
