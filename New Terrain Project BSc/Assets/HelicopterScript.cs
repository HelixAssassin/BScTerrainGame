﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterScript : MonoBehaviour {

    GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            gameManager.won = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
