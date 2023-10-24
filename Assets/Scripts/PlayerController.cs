using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    float delta;
    public float speed = 120f;
    public float jump_speed = 100f;
    public bool IsGrounded = true;
    public bool testbool = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        delta = Time.deltaTime;
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        rb.velocity = moveDirection;
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            //rb.isKinematic = false;
            //rb.AddForce(new Vector3(0.0f, jump_speed, 0.0f), ForceMode.Impulse);
            rb.velocity = rb.velocity + Vector3.up * jump_speed;
            IsGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.T) && testbool == true) 
        {
            testbool = false;
            rb.position += new Vector3(12*delta , 0.0f, 0.0f);
        }

        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground") // update the collision with ground bool
        {
            if (rb.velocity.y <= 0)
            {
                //rb.isKinematic = true;
            }
            IsGrounded = true;
        }
    }
}
