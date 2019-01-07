using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UIScript : MonoBehaviour {

    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;
    public Text scoreNum;
    public Text timenum;
    static int score;

    // Use this for initialization
    void Start() {

        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health: " + healthScript.getHealth();
    }

    public static void updateScore(int amount)
    {
        score += amount;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health: " + healthScript.getHealth();
        timenum.text = "" + (int)Time.time;
        scoreNum.text = score + "";


        if (healthScript.IsDead)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

}
