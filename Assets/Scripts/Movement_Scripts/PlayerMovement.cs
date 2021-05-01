using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    Vector3 velocity;
    float speed = 5f;
    float verticalSpeed = 7f;
    Vector3 mousePosition;
    private Vector3 objectPosition;
    private float angle;
    
    [SerializeField]
    GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
    }

    
    void FixedUpdate()
    {
       
        Clamp();

        
        
        velocity = new Vector3(Input.GetAxis("Horizontal")*speed,Input.GetAxis("Vertical")*verticalSpeed);
        transform.position += velocity  * Time.fixedDeltaTime;

      
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - firePoint.transform.position;
        angle = Mathf.Atan2(-mousePosition.x, mousePosition.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        firePoint.transform.rotation = Quaternion.Slerp(firePoint.transform.rotation,rotation,5f*Time.fixedDeltaTime);



    }
    private void Clamp()
    {
        Vector3 position = Camera.main.WorldToViewportPoint(transform.position);

      //  position.x = Mathf.Clamp01(position.x);
       position.y = Mathf.Clamp01(position.y);

        transform.position = Camera.main.ViewportToWorldPoint(position);

        if (transform.position.x <=-13f)
        {
            transform.position = new Vector3(13f, transform.position.y);

        }
        else if (transform.position.x >= 13f)
        {
            transform.position = new Vector3(-13f, transform.position.y);

        }
       
    }
    private void Move(float direction)
    {
        Vector3 force = transform.up * direction*speed;

        rb.AddForce(force);
    }
    private void Rotation(Transform t, float amount)
    {
        t.Rotate(0,amount,0);
    }

}
