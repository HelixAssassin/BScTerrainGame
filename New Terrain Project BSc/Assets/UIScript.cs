using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;
    public Text scoreNum;
    public Text timeNum;
    static int score;

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
	void Update ()
    {
        healthBar.value = healthScript.getHealth();
        healthTxt.text = "Health: " + healthScript.getHealth();
        timeNum.text = "" + (int)Time.time;
        scoreNum.text = score + "";
		

	}

    public static void updateScore(int amount)
        {
            score += amount;
        }


    IEnumerator updateUI()
    {
        healthbar.value = healthScript.getHealth();
        playerHealthTxt.text = "Health: " + healthScript.getHealth();
        timeNum.text = "" + (int)Time.time;
        scoreNum.text = score + "";

        if (healthScript.IsDead)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        yield return new WaitForSeconds(0.5f);
        StartCoroutine("updateUI");
    }

}
