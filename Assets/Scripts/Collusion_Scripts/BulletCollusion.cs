using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCollusion : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    public static int _score = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up*speed;
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            _score += 1;
          
        }

        if (collision.gameObject.CompareTag("BonusEnemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            _score += 5;

        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
