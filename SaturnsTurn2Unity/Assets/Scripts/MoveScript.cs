using UnityEngine;
using System.Collections;
/// <summary>
/// Moves the current game object
/// </summary>
public class MoveScript : MonoBehaviour {

	// Use this for initialization
    //variables

    public Vector2 speed = new Vector2(10, 10);

    //direction
    public Vector2 direction = new Vector2(-1, 0);

	void Start () 
    {
	

	}
	
	// Update is called once per frame
	void Update () 
    {
	
        // movement
        Vector3 movement = new Vector3(speed.x*direction.x,speed.y*direction.y,0);
        movement *= Time.deltaTime;
        transform.Translate(movement);



	}
}
