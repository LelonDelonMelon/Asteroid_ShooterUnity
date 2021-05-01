using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour
{
    PlayerMovement pm = new PlayerMovement();
    public static bool _restartButton;
    public static bool _quitButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {  
            Destroy(collision.gameObject);
            Destroy(gameObject);

            _restartButton = true;
            _quitButton = true;
        }
        


    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
