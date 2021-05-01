using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScripts : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    public static int _score = 0;

    [SerializeField]
    AudioSource aSource;
  
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
            FindObjectOfType<SoundManager>().Play("crash");
        }
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
