﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float movementSpeed;

	void Start () {
	    
	}
	
	void Update () {
        Vector3 currentPosition = transform.position;
        transform.position = new Vector3(currentPosition.x - movementSpeed, currentPosition.y, 
            currentPosition.z);
	}
}
