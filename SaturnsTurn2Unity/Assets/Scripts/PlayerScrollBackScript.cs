using UnityEngine;
using System.Collections;

public class PlayerScrollBackScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
       
        



        GameObject.Find("0-Background").GetComponent<ScrollingScript>().direction.x = 1;

        //ScrollingScript scrollBack = GetComponent<ScrollingScript>();
        //scrollBack.direction.x = -1;
        //scrollBack.direction.y = 0;

	
	}
}
