using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlAxis : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    public float minDistance = 2;

    Vector2 currentVelocity;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //biar si bola bamnteng jaga jarak #5M
        mousePosition += ((Vector2)transform.position - mousePosition).normalized * minDistance;
        transform.position = Vector2.SmoothDamp(transform.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }
}