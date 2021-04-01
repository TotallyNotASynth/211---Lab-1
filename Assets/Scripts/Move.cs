using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator playerAnimator;
    Rigidbody rb;
    int speed;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the comands to something easier to type.
        rb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Makes it go up
       if(Input.GetKeyDown (KeyCode.W))
        {
            speed = 1;
            rb.velocity = new Vector3(transform.position.x, speed, 0);
        } 
       //Makes it go down
       else if (Input.GetKeyDown (KeyCode.S))
        {
            speed = -1;
            rb.velocity = new Vector3(transform.position.x, speed, 0);
        }
       //Makes it stop
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = 0;
            rb.velocity = new Vector3(transform.position.x, speed, 0);
        }
       //sets the animator variable to trigger animations
        playerAnimator.SetFloat("speed", speed);

    }
}
