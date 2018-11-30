using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Slider playerHealth;
    public TextAlignment score;
    public TextAlignment playerHealthTxt;
    public TextAlignment timeTxt;

	// Use this for initialization
	void Start () {
        GameManager manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        healthBar = manager.playerHealth;
        healthTxt = manager.playerHealthTxt;
        scoreNum = manager.score;
        timeNum = manager.timeTxt;

        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health" + healthScript.getHealth();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
