using UnityEngine;
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
	
	// Update is called once per frame
	void Update ()
    {
        // 2 - retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 3 -movement per direction
        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        // 4 -Relative to the time
        movement *= Time.deltaTime;

        // 5 -move the game object
        transform.Translate(movement);

	
	}
}
