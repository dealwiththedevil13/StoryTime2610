using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JoystickBehavior : MonoBehaviour
{
    public Joystick stick;
    public Rigidbody playerRB;
    public float speed = 5f;
    public float turnSpeed = 4f;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //stick = GameObject.;

    }

    
    void Update()
    {
        
    }

    public void Move()
    {
        float joyhorizontalMove = stick.Horizontal * speed;
        float joyverticalMove = stick.Vertical * speed;

        Vector3 moveDirection = new Vector3();
        //float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        // playerRB.AddForce(Vector3.right * speed * horizontalInput);
    }
}
