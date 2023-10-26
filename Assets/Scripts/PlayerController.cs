using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float delta;
    Vector3 Curr_velocity;
    private float speed = 15f;
    private float jump_speed = 30f;
    private bool IsGrounded = true;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Curr_velocity = Vector3.zero;
        Physics.gravity = new Vector3 (0,-100,0);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            rb.AddForce(new Vector3(0.0f, jump_speed, 0.0f), ForceMode.Impulse);
            IsGrounded = false;
        }
    }
    void FixedUpdate()
    {
        delta = Time.deltaTime;
        float xDirection = Input.GetAxis("Horizontal")*speed;
        float zDirection = Input.GetAxis("Vertical")*speed;

        rb.velocity = new Vector3(xDirection,rb.velocity.y,zDirection);


        //moveDirection = new Vector3(xDirection, 0.0f, zDirection) * speed * delta;
        //rb.MovePosition(rb.position + moveDirection);
        //rb.AddForce(moveDirection, ForceMode.VelocityChange);
    }

    /*private void FixedUpdate()
    {
        transform.position += moveDirection;
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground") // update the collision with ground bool
        {
            IsGrounded = true;
        }
    }
}
