using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    float nextTimeAttackIsAllowed = -1.0f;

    // This dictates the time delay between melee attacks for the enemy.
    [SerializeField] float attackDelay = 1.0f;

    // This dictates the amount of damage that the enemy can deal.
    [SerializeField] int damageDealt =5;

    // This makes sure that the enemy can only damage an object that is tagged with Player.
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player"&&Time.time>=nextTimeAttackIsAllowed) {
            Health playerHealth = other.GetComponent<Health>();
            playerHealth.Damage(damageDealt);
            nextTimeAttackIsAllowed = Time.time + attackDelay;
        }
    }

    // Use this for initialization
    void Start () {
        Animator anim;
        {
            anim = GetComponentInParent<Animator>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}