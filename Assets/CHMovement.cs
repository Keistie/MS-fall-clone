using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHMovement : MonoBehaviour
{
    public float speed = 2.0f;

    public float dirY; 

    public float dirX;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;    

    Vector3 chickenStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        chickenStartPosition = rb.transform.localPosition;
        dirX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            dirY = speed;      
        }

        if(Input.GetKey(KeyCode.S)){
            dirY = -speed;
        }

        if(!Input.anyKey){
            dirY = 0;
        }
        //movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(dirY));

    }

    void FixedUpdate()
    {
            rb.velocity = new Vector2 (dirX, dirY);
      //  rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
