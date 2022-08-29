using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float xSpeed;
    public float ySpeed;
    public float xRotation;
    public float yRotation;

    void Start()
    {
        // Destroy game object after a random amount of time
        float lifeTime = Random.Range(3f, 10f);
        Destroy(gameObject, lifeTime);



    }

    void FixedUpdate()
    {
        Vector2 noise = new Vector2(Random.Range(-xSpeed/5, xSpeed/5), Random.Range(-ySpeed/5, ySpeed/5));
        rb.velocity = SpiralVelocity() + noise;
    }


    private Vector2 SpiralVelocity()
    {
        /* Ugly random behavior
        float vx = Random.Range(0, xSpeed);
        float vy = Random.Range(0, ySpeed);
        float thetax = Random.Range(0, xRotation);
        float thetay = Random.Range(0, yRotation);
        
        Vector2 velocity = new Vector2(vx * Mathf.Cos(thetax * Time.time), 
                                       vy * Mathf.Sin(thetay * Time.time));
        */
        Vector2 velocity = new Vector2(xSpeed * Mathf.Cos(xRotation* Time.time),
                                       ySpeed * Mathf.Sin(yRotation * Time.time));

        return velocity;


    }
}
