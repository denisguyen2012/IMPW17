using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdMovement : MonoBehaviour {

    public Vector3 jumpForce;
    private Rigidbody rigidBody;

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	void Update () {
	    if(Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(jumpForce);
        }
	}
}
