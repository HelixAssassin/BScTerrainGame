using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    //This varaibale says that the maximum health will be 100 which can go down to 0.
    [SerializeField] int maximumHealth = 100;
    int currentHealth = 0;

	// Use this for initialization
	void Start () {
        currentHealth = maximumHealth;
	}

    //This means when the health reaches 0 the player will be dead.
    public bool IsDead { get { return currentHealth <= 0; } }

    public int getHealth()
    {
        return currentHealth;
    }

    public int getMaxHealth()
    {
        return maximumHealth;
    }

    // This tells the script to destroy the game object once the object health has reached 0.
    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;

        if (currentHealth <= 0) {
            Destroy(gameObject);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
