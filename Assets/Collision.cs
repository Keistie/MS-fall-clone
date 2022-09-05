using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Rigidbody2D rb;

    public float distance;

   // public GameObject player;

    public playerreset player;

    Vector2 movement;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.y = distance;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Car"){

            Debug.Log("Hit");
            player.ResetPlayer();
            //this.gameObject.SetActive(false);
           // player.GetComponent<CHMovement>().enabled = false;
          //  rb.MovePosition(rb.position - movement * Time.fixedDeltaTime);
           // player.GetComponent<CHMovement>().enabled = true;
        }
       // player.GetComponent<CHMovement>().enabled = true;
        //this.gameObject.SetActive(true);
    }
}
