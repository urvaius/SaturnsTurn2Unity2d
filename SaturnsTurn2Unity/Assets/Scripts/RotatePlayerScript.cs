using UnityEngine;
using System.Collections;

public class RotatePlayerScript : MonoBehaviour
{

   // Vector3 rotateMovement;
    public float speed = 3f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        


        // 2 - retrieve axis information
       // float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Vertical");

        // 3 -movement per direction
       // rotateMovement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        // 4 -Relative to the time
       // rotateMovement *= Time.deltaTime;

        // 5 -move the game object
        //transform.Translate(rotateMovement);
        if (Input.GetButton("rotateLeft"))
        {
            RotateLeft();
        }
        if (Input.GetButton("rotateRight"))
        {
            RotateRight();
        }
        


        
	
	}

    void RotateLeft()
    {
       // transform.Rotate(Vector3.forward * 1 );
        transform.Rotate(Vector3.forward * 1 * speed);
    }

    void RotateRight()
    {
        transform.Rotate(Vector3.forward * -1 * speed);

    }
}
