using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour
{
    public Rigidbody2D carrb;

    public float carspeed;

    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = carspeed;
    }

    void FixedUpdate()
    {
        carrb.MovePosition(carrb.position + movement * Time.fixedDeltaTime);
}
}
