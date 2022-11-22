using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 12.0f;
    private float currentPositionX;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InBounds(); //Keeps the player in the bounds of the play area
        FireProjectile(); //Instantiates a projectile from players location

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    void InBounds()
    {
        currentPositionX = transform.position.x;

        if (currentPositionX < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (currentPositionX > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void FireProjectile()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch projectile
        }
    }
}
