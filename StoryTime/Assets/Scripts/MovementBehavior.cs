using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float Speed = 20f;
    private float horizontalMove = 5f;
    public Rigidbody playerRB;
    public Joystick stick;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        var stickHorizontal = horizontalMove * stick.Horizontal * Speed;
    }
}
