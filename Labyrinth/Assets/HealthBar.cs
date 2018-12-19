﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    Image healthBar;
    float max = 100f;
    public static float health;
	// Use this for initialization
	void Start () {
        healthBar = GetComponent<Image>();
        health = max;
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount = health / max;
		
	}
}