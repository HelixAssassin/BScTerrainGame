using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour {

        
        void OnEnable()
        {
            // This allows the door to go up
            this.transform.position =
                new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
        }

        
        void OnDisable()
        {
            // This allows the door to go down
            this.transform.position =
                new Vector3(transform.position.x, transform.position.y - 3, transform.position.z);
        }

}