﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretWeakSpot : MonsterPart
{
    public GameObject TurretGO;
    public Turret Turret;   

    public override void OnHit()
    {
        base.OnHit();
        Health -= 25;
        if (Health <= 0)
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
        Turret.OnDeath();
    }
}
