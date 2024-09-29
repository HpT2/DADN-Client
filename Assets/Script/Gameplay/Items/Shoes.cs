using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoes 
{
    public ShoesConfig config;
    public void Apply(ShoesConfig newConfig, Player player)
    {
        //remove old stat then apply new stat
        if (config != null)
        {
            player.totalStats.atk -= config.atk;
            player.totalStats.moveSpd -= config.moveSpd;
        }

        config = newConfig;
        player.totalStats.atk += config.atk;
        player.totalStats.moveSpd += config.moveSpd;
    }
}
