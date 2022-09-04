using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch1collide : MonoBehaviour
{
    public Rigidbody2D rb;

    public float distance = 1.5f; 

   // public Movement playermove;

    Vector2 movement;

    void Update () {
        movement.y = distance;  
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Car"){
            //playermove.SetActive(false);
            this.gameObject.SetActive(false);
            rb.MovePosition(rb.position - movement * Time.fixedDeltaTime);
        }   
        this.gameObject.SetActive(true);
        //playermove.SetActive(true);
    }
}
