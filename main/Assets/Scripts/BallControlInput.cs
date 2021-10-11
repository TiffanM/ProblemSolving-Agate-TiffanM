using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlInput : MonoBehaviour
{
    private ContactPoint2D lastContactPoint;
    
    public KeyCode upButton = KeyCode.UpArrow;
    public KeyCode downButton = KeyCode.DownArrow;
    public KeyCode leftButton = KeyCode.LeftArrow;
    public KeyCode rightButton = KeyCode.RightArrow;
    public float speed = 10.0f;
    public float yBoundary = 10.0f;
    
    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
        rigidBody2D.velocity = velocity;
        Vector3 position = transform.position;
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }
        transform.position = position;
    }
}
