using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor 
{
    public ArmorConfig config;
    public void Apply(ArmorConfig newConfig, Player player)
    {
        //remove old stat then apply new stat
        if (config != null)
        {
            player.totalStats.maxHP -= config.HP;
            player.totalStats.def -= config.def;
        }

        config = newConfig;
        player.totalStats.maxHP += config.HP;
        player.totalStats.def += config.def;
    }
}
