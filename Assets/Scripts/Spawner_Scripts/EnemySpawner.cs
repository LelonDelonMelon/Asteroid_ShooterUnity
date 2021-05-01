using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{

    [Header("Enemy")]
    public GameObject _enemyPrefab;
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
        if(_instantiateTime > 0.4)
        {
            EnemyInstantiate();
            _instantiateTime = 0;
        }
        
    }

    void EnemyInstantiate()
    {
       // counter++;
        x = Random.Range(-11, 11);
        y = Random.Range(8,10);
        _enemyInstantiatePosition = new Vector3(x, y, 0);
        Instantiate(_enemyPrefab, _enemyInstantiatePosition, Quaternion.identity);

    }


}
