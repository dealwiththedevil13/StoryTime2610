using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JoystickBehavior : MonoBehaviour
{
    public Joystick stick;
    public Rigidbody playerRB;
    public float speed = 5f;
    public float turnSpeed = 4f;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(Vector3.right * speed * horizontalInput);
    }
}
