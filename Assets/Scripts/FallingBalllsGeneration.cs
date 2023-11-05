using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class FallingBalllsGeneration : MonoBehaviour
{
    public GameObject small_ball;  
    public float xPos;
    public float yPos;
    public float zPos;
    public float xVel;
    public float zVel;
    public int Num_balls;
    public float _wait_between_balls = 1f;
    void Start()
    {   
        xPos = GameObject.Find("Pyramid_Thin_Tip").transform.position.x;
        yPos = GameObject.Find("Pyramid_Thin_Tip").transform.position.y;
        zPos = GameObject.Find("Pyramid_Thin_Tip").transform.position.z;

        xVel = Random.Range(-5, 5);
        zVel = Random.Range(-5, 5);
        GameObject ball = Instantiate(small_ball, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        ball.TryGetComponent(out Rigidbody rb);
        rb.velocity = new Vector3(xVel, 10, zVel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
        IEnumerator BallWave() 
        {
            xVel = Random.Range(-5, 5);
            zVel = Random.Range(-5, 5);
            GameObject ball = Instantiate(small_ball, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            ball.TryGetComponent(out Rigidbody rb);
            rb.velocity = new Vector3(xVel, 10, zVel);
            Num_balls += 1;
            yield return new WaitForSeconds(_wait_between_balls);
        }
    */
}
