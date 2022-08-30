using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : Enemy 
{
    public override void PlayerImpact(Player player)
    {
        // base.PlayerImpact(Player);
        player.Kill();
    }
}
