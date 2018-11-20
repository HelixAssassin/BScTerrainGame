using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour {

    [SerializeField] int damageDealt = 20;
    [SerializeField]
    LayerMask layermask;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>(); 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        layermask = Physics.IgnoreRaycastLayer;
        layermask = ~layermask;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(mouseRay, out hitInfo, 100, ~layermask))
            print(hitInfo.transform);

		if (Input.GetKey(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        if (Input.GetButtonDown ("Fire2")) {
            //Make a raycast with the line starting from center of camera
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            //Send the raycast and if the raycast hit something, print out the name to console
            if (Physics.Raycast (mouseRay, out hitInfo)) {
                Debug.DrawLine(transform.position, hitInfo.point,Color.red,5.0f);
                Health enemyHealth = hitInfo.transform.GetComponent<Health>();
                if(enemyHealth !=null)
                {
                    enemyHealth.Damage(damageDealt);
                }
            }
        }
	}
}
