﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealthBar : MonoBehaviour
{

    public RectTransform rt;
    public Text t;

    // Use this for initialization
    void Start()
    {
        rt = this.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rt.sizeDelta = new Vector2(1090 * Mathf.Max(0, GameController.obj.Wurm2Hit.health / 100f), 40);
        t.text = GameController.obj.Wurm2Hit.health + " / 100";
    }
}
