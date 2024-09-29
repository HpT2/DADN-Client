using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    public WeaponConfig config;
    public void Apply(WeaponConfig newConfig, Player player)
    {
        //remove old stat then apply new stat
        if(config != null)
        {
            player.totalStats.atk -= config.atk;
            player.totalStats.atkRange -= config.atkRange;
        }

        config = newConfig;
        player.totalStats.atk += config.atk;
        player.totalStats.atkRange += config.atkRange;
    }
}
