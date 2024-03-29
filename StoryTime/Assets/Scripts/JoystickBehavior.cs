using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JoystickBehavior : MonoBehaviour
{
    public FixedJoystick stick;
    public Rigidbody playerRB;
    public float speed = 5f;
    public float turnSpeed = 4f;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //stick = GameObject.;

    }

    public void Update()
    {
        Move();
    }
    //private Vector3 move = ; 
    

    public void Move()
    {
        float hor = stick.Horizontal;
        float ver = stick.Vertical;
        
        //playerRB.velocity = new Vector3(hor * speed, playerRB.velocity.y, ver * speed);
        playerRB.velocity = new Vector3(hor * speed * Time.deltaTime, playerRB.velocity.y, ver * speed * Time.deltaTime);
        Vector3 direction = new Vector3(hor, 0, ver).normalized;
        playerRB.AddForce(direction * (speed * Time.deltaTime));
        transform.rotation = Quaternion.LookRotation(direction);
        
        
        
        //transform.Translate(direction * speed, Space.World);
        //float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        //playerRB.AddForce(Vector3.right * (speed * turnSpeed * horizontalInput));
        // playerRB.AddForce(Vector3.forward * (speed * verticalInput));
    }

    
}
