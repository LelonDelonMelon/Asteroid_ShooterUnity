using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemySpawner : MonoBehaviour
{
    [Header("Enemy")]
    public GameObject _movingEnemyPrefab;
    public static float x;
    public static float y;
    Vector3 _enemyInstantiatePosition;
    float _instantiateTime = 0;
    //int counter = 0;

    Vector3 rightForce = new Vector3(500, y, 0);
    int speed = 500;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _instantiateTime += Time.deltaTime;
        if (_instantiateTime > 3)
        {

            EnemyInstantiate();
            _instantiateTime = 0;

        }


    }

    void EnemyInstantiate()
    {
        // counter++;
        x = Random.Range(-7, 7);
        y = Random.Range(8, 10);
        _enemyInstantiatePosition = new Vector3(x, y, 0);
        Instantiate(_movingEnemyPrefab, _enemyInstantiatePosition, Quaternion.identity);

    }
}
