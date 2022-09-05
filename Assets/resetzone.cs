using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetzone : MonoBehaviour
{
    public carreset slowcar;
    public carreset secondslowcar;
    public carreset mediumcar;
    public carreset secondmediumcar;
    public carreset fastcar;
    public carreset secondfastcar;
    public carreset mediumcartwo;
    public carreset secondmediumcartwo;
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
        if(collision.gameObject == mediumcartwo.gameObject){
            mediumcartwo.ResetCar();
        }
        if(collision.gameObject == secondslowcar.gameObject){
            secondslowcar.ResetCar();
        }
        if(collision.gameObject == secondmediumcar.gameObject){
            secondmediumcar.ResetCar();
        }
        if(collision.gameObject == secondfastcar.gameObject){
            secondfastcar.ResetCar();
        }
        if(collision.gameObject == secondmediumcartwo.gameObject){
            secondmediumcartwo.ResetCar();
        }
    }
}
