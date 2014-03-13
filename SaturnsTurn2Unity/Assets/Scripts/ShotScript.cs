using UnityEngine;
using System.Collections;
/// <summary>
/// projetile behavior
/// </summary>
public class ShotScript : MonoBehaviour {

	// Use this for initialization
	//damage inflicted
	public int damage = 1;

  
	/// <summary>
	/// Projectile damage player or enemies?
	/// </summary>
	public bool isEnemyShot = false;

	void Start ()
	{
		
		// 2 - Limited time to live to avoid any leak
		Destroy(gameObject, 20); // 20sec
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	}
}
