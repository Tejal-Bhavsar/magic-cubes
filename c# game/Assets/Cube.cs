using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D  myRigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetKeyDown(KeyCode.UpArrow))
       {
           myRigidBody2d.velocity = new Vector2(0, 10f);
       }

        if ( Input.GetKeyDown(KeyCode.DownArrow))
       {
           myRigidBody2d.velocity = new Vector2(0, -10f);
       }

        if ( Input.GetKeyDown(KeyCode.RightArrow))
       {
           myRigidBody2d.velocity = new Vector2(10f, 0f);
       }

        if ( Input.GetKeyDown(KeyCode.LeftArrow))
       {
           myRigidBody2d.velocity = new Vector2(-10, 0f);
       }
    }
}
