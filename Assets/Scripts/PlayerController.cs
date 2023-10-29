using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 15f;
    private float jump_speed = 30f;
    private bool IsGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3 (0,-100,0); //TODO: this should be in another script - something like "UniverseSettings.cs"
    }

    void Update()
    {
        //simple Jumping mechanic
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            rb.AddForce(new Vector3(0.0f, jump_speed, 0.0f), ForceMode.Impulse);
        }
        if (Input.GetButtonDown("Jump")) //just checking how Debug.Log works
        {
            Debug.Log("Jump is pressed!");
        }
    }
    void FixedUpdate()
    {
        //pressing buttons sets the velocity of the player directly.
        float xDirection = Input.GetAxis("Horizontal") * speed;
        float zDirection = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(xDirection,rb.velocity.y,zDirection); 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground") // update the collision with ground bool
        {
            IsGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision) 
    {
        if(collision.gameObject.name == "Ground") // update the collision with ground bool
        {
            IsGrounded = false; 
        }
    }
}
