using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform targetPosition;

    [SerializeField]
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Follow();
    }
    [Range(1, 10)]
    public float smoothFactor;
    private void Follow()
    {
        transform.position = targetPosition.position;

        Vector3 targetPos = targetPosition.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, targetPos, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPos;

    }
}
