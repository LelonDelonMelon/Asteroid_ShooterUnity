using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEnemyRotater : MonoBehaviour
{
    /// <summary>The objects initial position.</summary>
    private Vector2 startPosition;
    /// <summary>The objects updated position for the next frame.</summary>
    private Vector2 newPosition;

    /// <summary>The speed at which the object moves.</summary>
    [SerializeField] private int speed = 3;
    /// <summary>The maximum distance the object may move in either y direction.</summary>
    [SerializeField] private int maxDistance = 1;
    [SerializeField] private float gravity = 1f;

    void Start()
    {
        newPosition = transform.position;
        
    }

    void Update()
    {
        startPosition = transform.position;
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.deltaTime * speed));
        newPosition.y = startPosition.y - gravity * Time.deltaTime;
        transform.position = newPosition;
        transform.Rotate(0, 7, 0);
    }
}
