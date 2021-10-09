using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlAxis : MonoBehaviour
{
  //public float yBoundary = 10.0f;
  //public float xBoundary = 10.0f;
  //public float speed = 10.0f;

  //void Update()
  //{
     // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      //mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
     // transform.position = mousePosition;
  //}

    public float moveSpeed = 10;
    //buat pergerakan bola ngikut kursor amjay berhasil walau cuma copas sana sini
    //kalo pergerakan bola menyamai kecepatan kursor bakal tembus tembok
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}