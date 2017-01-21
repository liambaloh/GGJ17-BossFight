﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitEffect : MonoBehaviour
{

    public virtual void OnHit(Bullet bullet)
    {
        //NOOP
    }

    public virtual void OnHit(Rocket rocket)
    {
        //NOOP
    }
}
