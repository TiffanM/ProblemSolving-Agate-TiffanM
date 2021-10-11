using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public float Health = 50f;
    public UnityAction<GameObject> OnEnemyDestroyed = delegate { };

    private bool _isHit = false;

    void OnDestroy()
    {
        if (_isHit)
        {
            OnEnemyDestroyed(gameObject);
            //Spawner1.IncreaseScore();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>() == null) return;


        if (col.gameObject.tag == "Ball")
        {
            _isHit = true;
            Destroy(gameObject);
            ScoreManager.scoreValue += 1;
        }
        //buat nanti problem 9 kalo bisa :(
        else if (col.gameObject.tag == "Bullet")
        {
            float damage = col.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Health -= damage;

            if (Health <= 0)
            {
                _isHit = true;
                Destroy(gameObject);
            }
        }
    }
}
