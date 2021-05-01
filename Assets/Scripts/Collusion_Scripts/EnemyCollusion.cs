using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCollusion : MonoBehaviour
{
    PlayerMovement pm = new PlayerMovement();
    public static bool _restartButton;
    public static bool _quitButton;
    public static int _remainingLife = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if (gameObject.CompareTag("LifeEnemy"))
            {
                if(_remainingLife < 3)
                {
                    _remainingLife++;
                }
                GameSceneManager._upgradeWeapon = true;
                Destroy(gameObject);
            }
            else
            {
                FindObjectOfType<SoundManager>().Play("Crash_Player_1");
                if (_remainingLife == 1)
                {
                    _remainingLife--;
                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                    _restartButton = true;
                    _quitButton = true;
                }
                else
                {
                    Destroy(gameObject);
                    _remainingLife--;
                }
            }
            
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (!gameObject.CompareTag("LifeEnemy"))
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);

                FindObjectOfType<SoundManager>().Play("Crash");

            }

        }



    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
