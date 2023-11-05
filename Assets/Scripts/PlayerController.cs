using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask Ground;
    public Rigidbody rb;
    private float speed = 15f;
    private float jump_speed = 30f;

    //TODO: fix the length of those vectors:
    public Vector3 ray1 = Vector3.Normalize(new Vector3( 0, -1, 0));//this length is perfect
    public Vector3 ray2 = Vector3.Normalize(new Vector3(0, -1, -1));
    public Vector3 ray3 = Vector3.Normalize(new Vector3(0, -1,  1));
    public Vector3 ray4 = Vector3.Normalize(new Vector3(-1, -1, 0));
    public Vector3 ray5 = Vector3.Normalize(new Vector3(-1, -1,-1));
    public Vector3 ray6 = Vector3.Normalize(new Vector3(-1, -1, 1));
    public Vector3 ray7 = Vector3.Normalize(new Vector3( 1, -1,-1));
    public Vector3 ray8 = Vector3.Normalize(new Vector3( 1, -1, 0));
    public Vector3 ray9 = Vector3.Normalize(new Vector3( 1, -1, 1));

    void Start()
    {
        Debug.Log(ray1.ToString());
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3 (0,-100,0); //TODO: this should be in another script - something like "UniverseSettings.cs"
    }

    void Update()
    {
        //simple Jumping mechanic
        if (Input.GetButtonDown("Jump") && CheckGrounded())
        {
            rb.AddForce(new Vector3(0.0f, jump_speed, 0.0f), ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        //pressing buttons sets the velocity of the player directly.
        float xDirection = Input.GetAxis("Horizontal") * speed;
        float zDirection = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(xDirection,rb.velocity.y,zDirection); 
    }

    public bool CheckGrounded()
    {
        if (Physics.Raycast(rb.position, ray1, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray2, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray3, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray4, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray5, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray6, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray7, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray8, 4f, LayerMask.GetMask("Ground")) ||
            Physics.Raycast(rb.position, ray9, 4f, LayerMask.GetMask("Ground")))
        {
            return true;
        }
        return false;
    }
}
