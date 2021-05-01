using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBullet;
    public Text _scoreText;

    [SerializeField]
    Animator gunAnimator;

    public Transform firePoint;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(GameSceneManager._upgradeWeapon == true)
        {
                if (Input.GetMouseButton(0))
                {
                    shoot();
                }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shoot();
            }
        }
        
        _scoreText.text = "Score: " + BulletCollusion._score;
    }
    private void shoot()
    {
        Instantiate(prefabBullet,firePoint.position,firePoint.rotation);
        FindObjectOfType<SoundManager>().Play("Shoot");
        gunAnimator.SetTrigger("Shoot");
    }


}
