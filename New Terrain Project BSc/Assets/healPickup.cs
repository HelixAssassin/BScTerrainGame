using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        //print("pick up");
        Health health = collider.GetComponent<Health>();
        if (health != null&&collider.tag=="Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            health.Damage(-50);
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
