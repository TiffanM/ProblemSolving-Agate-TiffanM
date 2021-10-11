using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;

    //buat problem 2
    public float xInitialForce = 10f;
    public float yInitialForce = 10f;
    void ResetBall()
    {
        //reset posisi
        transform.position = Vector2.zero;
        //reset velocity
        rigidBody2D.velocity = Vector2.zero;
    }
    void PushBall()
    {
        //buat nilai y
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);
        //titik acak
        float randomDirection = Random.Range(0, 2);
        //arah bola random
        if (randomDirection < 1.0f)
        {
            //penggerak bola
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }
    void RestartGame()
    {
        //reset bola
        ResetBall();
        Invoke("PushBall", 2);
    }
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //buat mulai game
        RestartGame();
    }
}
