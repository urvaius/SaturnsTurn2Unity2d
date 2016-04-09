using UnityEngine;

/// <summary>
/// Launch projectile
/// </summary>
public class WeaponScript : MonoBehaviour
{
    //--------------------------------
    // 1 - Designer variables
    //--------------------------------

    /// <summary>
    /// Projectile prefab for shooting
    /// </summary>
    public Transform shotPrefab;

    /// <summary>
    /// Cooldown in seconds between two shots
    /// </summary>
    public float shootingRate = 0.25f;
    public float speed = 10;
	public float projectileSpeed = 5;
    //--------------------------------
    // 2 - Cooldown
    //--------------------------------

    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    //--------------------------------
    // 3 - Shooting from another script
    //--------------------------------

    /// <summary>
    /// Create a new projectile if possible
    /// </summary>
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;

            // Create a new shot
           // var shotTransform = Instantiate(shotPrefab) as Transform;
            Vector3 shotPosition = new Vector3(transform.position.x,transform.position.y );
             var shotTransform = Instantiate(shotPrefab,shotPosition,Quaternion.Euler(shotPosition)) as Transform;
           
            
            // Assign position
           //  Vector3 newRotation = transform.rotation.eulerAngles;
           //  newRotation.x += transform.position.x;
           //  newRotation.y += transform.position.y;
           //  shotTransform.rotation = Quaternion.Euler(newRotation);
           //// shotTransform.position = transform.position;
            
           // shotTransform.rigidbody.AddRelativeForce(Vector3.forward * speed);

            // The is enemy property
            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

            // Make the weapon shot always towards it
            MoveShotScript move = shotTransform.gameObject.GetComponent<MoveShotScript>();
            if (move != null)
            {
                
               // move.direction = this.transform.up; // towards in 2D space is the right of the sprite
				move.direction = transform.up;
               
            }
        }
    }

    /// <summary>
    /// Is the weapon ready to create a new projectile?
    /// </summary>
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}
