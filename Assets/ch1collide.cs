using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch1collide : MonoBehaviour
{
    public Rigidbody2D rb;

    public float distance = 1.5f; 

    Vector2 movement;

    void Update () {
        movement.y = distance;  
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        
        rb.MovePosition(rb.position - movement);
    }
}
