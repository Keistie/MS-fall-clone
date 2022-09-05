using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerreset : MonoBehaviour
{
    public Rigidbody2D player;
    Vector3 playerStartPosition;
    void Start()
    {
        playerStartPosition = player.transform.localPosition;
    }

    
    public void ResetPlayer(){
        player.transform.localPosition = playerStartPosition;
    }

    void Update()
    {
        
    }
}
