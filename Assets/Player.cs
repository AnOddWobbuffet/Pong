using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool isLeftSide;
    public float speed;
    public Rigidbody2D rigidBody;


    //[SerializeField] private Ball hehe;
    private float movement;

    // Update is called once per frame
    void Update()
    {
        if (isLeftSide)
        {
            movement = Input.GetAxisRaw("VerticalLeft");
        }    
        else
        {
            movement = Input.GetAxisRaw("VerticalRight");
        }

        rigidBody.velocity = new Vector2(rigidBody.velocity.x, movement * speed);
    }
    
}
