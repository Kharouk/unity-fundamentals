using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody RB;
    public float forwardForce = 2000f; // default to 2000. 
    public float xAxisForce = 500f;
    public float xAxisInput;


    private const string Message = "Welcome to the Fundamentals!"; // Doesn't appear on Unity.

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Message);
        RB = GameObject.Find("Player").GetComponent<Rigidbody>(); // Allows us to automatically assign the correct RigidBody
    }

    // Update is called once per frame 
    // Unity prefers FixedUpdate when dealing with updating/messing with physics or velocity. 
    void FixedUpdate()
    {
        /* 
         * deltaTime is lower on higher end computers, while bigger on lower end. This balances out FPS 
         * so that everyone has equal amount of force. 
        */
        RB.AddForce(0, 0, stabilizeSpeed(forwardForce));

        xAxisInput = Input.GetAxis("Horizontal") * xAxisForce;
        RB.AddForce(stabilizeSpeed(xAxisInput), 0, 0);

        // OR:
//         if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
//         {
//             Debug.Log("You've hit right.");
//             RB.AddForce(stabilizeSpeed(xAxisForce), 0, 0);
//         }
//         if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
//         {
//             Debug.Log("You've hit left.");
//             RB.AddForce(stabilizeSpeed(-xAxisForce), 0, 0);
//         }
    }

    float stabilizeSpeed(float num)
    {
        return num * Time.deltaTime;  // adds a directional force on the z-axis.
    }
}
