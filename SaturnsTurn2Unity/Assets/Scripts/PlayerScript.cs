﻿using UnityEngine;
using System.Collections;




/// <summary>
/// Player control and Movement
/// </summary>
public class PlayerScript : MonoBehaviour {
    /// <summary>
    /// 1 - speed
    /// </summary>

    public Vector2 speed = new Vector2(50, 50);



	// Use this for initialization
	void Start () 
    {
	
	}

    void OnDestroy()
    {
        // Game Over.
        // Add the script to the parent because the current game
        // object is likely going to be destroyed immediately.
        transform.parent.gameObject.AddComponent<GameOverScript>();
    }

	// Update is called once per frame
	void Update ()
    {
        // 2 - retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 3 -movement per direction
       // Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);
        Vector3 movement = new Vector3(0, speed.y * inputY, 0);
        // 4 -Relative to the time
        movement *= Time.deltaTime;

        // 5 -move the game object
        transform.Translate(movement);

        //shooting
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if(shoot)
        {
            WeaponScript weapon = GetComponent<WeaponScript>();
            if (weapon!=null)
            {
                //false because the player i snot an enemy
                weapon.Attack(false);
                SoundEffectsHelper.Instance.MakePlayerShotSound();

            }
        }
	
        //6 make sure we are not outside of camera bounds
        var dist = (transform.position - Camera.main.transform.position ).z;

        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0, dist )).x  ;

        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;

        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;

        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,dist)).y;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBorder, rightBorder), Mathf.Clamp(transform.position.y, topBorder, bottomBorder), transform.position.z);

	}
}
