using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController charController;

    //This part of the code allows the player to move in different directions and also sets the jump speed, move speed and gravity
    [SerializeField] float jumpSpeed = 20.0f;
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;

    [SerializeField] float moveSpeed = 5.0f;
    public float h;
    public float v;

	// Use this for initialization
	void Start () {
        charController = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // This is the movespeed variable for the player and this allows the object to move.
        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * moveSpeed;

        if (charController.isGrounded) {
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }

        } else{
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;

        velocity = transform.TransformDirection(velocity);

        charController.Move(velocity*Time.deltaTime);
		
	}
}
