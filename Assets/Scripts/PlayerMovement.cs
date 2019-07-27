using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody RB; 

    private const string Message = "Welcome to the Fundamentals!";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Message);
    }

    // Update is called once per frame 
    // Unity prefers FixedUpdate when dealing with updating/messing with physics or velocity. 
    void FixedUpdate()
    {
        // deltaTime is lower on higher end computers, while bigger on lower end. This balances out FPS
        // so that everyone has equal amount of force.
        RB.AddForce(0, 0, 2000 * Time.deltaTime); // adds a force of 2000 on  the z-axis
    }
}
