using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Slider playerHealth;
    public TextAlignment score;
    public TextAlignment playerHealthTxt;
    public TextAlignment timeTxt;
    private bool won;
    public GameObject winPanel;
    public GameObject losePanel;

    public GameObject helicopter;

    public static int amountKilled;

    public static int amountkilled { get; internal set; }


    // Use this for initialization
    void Start () {
        winPanel.SetActive(false);
        amountkilled = 0;
  
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeSinceLevelLoad > 180)
        {
            won = true; 
        }

        if (won == true)
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }
        else if (amountKilled > 30)
        {
            helicopter.GetComponent<Animation>()["CopterArrive"].wrapMode = WrapMode.ClampForever;
            helicopter.GetComponent<Animation>().Play("CopterArrive");
        }
    }
}