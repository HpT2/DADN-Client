using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet 
{
    public HelmetConfig config;
    public void Apply(HelmetConfig newConfig, Player player)
    {
        //remove old stat then apply new stat
        if (config != null)
        {
            player.totalStats.def -= config.def;
            player.totalStats.expGain -= config.expGain;
        }

        config = newConfig;
        player.totalStats.def += config.def;
        player.totalStats.expGain += config.expGain;
    }
}
