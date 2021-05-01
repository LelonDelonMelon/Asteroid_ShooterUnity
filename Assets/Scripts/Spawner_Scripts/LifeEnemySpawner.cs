using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeEnemySpawner : MonoBehaviour
{

    [Header("LifeEnemy")]
    public GameObject _bonusEnemyPrefab;
    public static float x;
    public static float y;
    Vector3 _enemyInstantiatePosition;
    float _instantiateTime = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _instantiateTime += Time.deltaTime;
        if (_instantiateTime > 10)
        {
            EnemyInstantiate();
            _instantiateTime = 0;
        }


    }

    void EnemyInstantiate()
    {
        // counter++;
        x = Random.Range(-10, 4);
        y = Random.Range(8, 10);
        _enemyInstantiatePosition = new Vector3(x, y, 0);
        Instantiate(_bonusEnemyPrefab, _enemyInstantiatePosition, Quaternion.identity);

    }


}
