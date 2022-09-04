using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollide : MonoBehaviour
{
    public Rigidbody2D chickenrb;

    public float distance = 1.5f;

    public GameObject player;

    Vector2 movement;

    void Update()
    {
        movement.y = distance;  
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Player"){
            //playermove.SetActive(false);
            player.GetComponent<CHMovement>().enabled = false;
            chickenrb.MovePosition(chickenrb.position - movement * Time.fixedDeltaTime);
        }   
        player.GetComponent<CHMovement>().enabled = true;
        //playermove.SetActive(true);
}
}