﻿using UnityEngine;
using System.Collections;

public class MoveShotScript : MonoBehaviour
{
    
    public Vector2 speed = new Vector2(10, 10);

    //direction
    public Vector2 direction = new Vector2(-1, 0);


	// Use this for initialization
	void Start ()
    
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    
    {
        // movement
        Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
        movement.Normalize();
        movement *= Time.deltaTime;
        
        transform.Translate(movement);
        
	}
}