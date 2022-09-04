using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetzone : MonoBehaviour
{
    public carreset slowcar;
    public carreset mediumcar;
    public carreset fastcar;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject == slowcar.gameObject){
            slowcar.ResetCar();
        }
        if(collision.gameObject == mediumcar.gameObject){
            mediumcar.ResetCar();
        }
        if(collision.gameObject == fastcar.gameObject){
            fastcar.ResetCar();
        }
    }
}
