using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetzoneleft : MonoBehaviour
{
    public carreset slowcarup;
    public carreset secondslowcarup;
    public carreset secondslowcarup2;
    public carreset slowcar2up;
    public carreset secondslowcar2up;
    public carreset mediumcarup;
    public carreset secondmediumcarup;
    public carreset mediumcar2up;
    public carreset secondmediumcar2up;
    public carreset fastcarup;
    public carreset secondfastcarup;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject == slowcarup.gameObject){
            slowcarup.ResetCar();
        }
        if(collision.gameObject == mediumcarup.gameObject){
            mediumcarup.ResetCar();
        }
        if(collision.gameObject == fastcarup.gameObject){
           fastcarup.ResetCar();
        }
        if(collision.gameObject == slowcar2up.gameObject){
           slowcar2up.ResetCar();
        }
        if(collision.gameObject == mediumcar2up.gameObject){
            mediumcar2up.ResetCar();
        }
        if(collision.gameObject == secondslowcarup.gameObject){
            secondslowcarup.ResetCar();
        }
        if(collision.gameObject == secondslowcarup2.gameObject){
            secondslowcarup2.ResetCar();
        }
        if(collision.gameObject == secondslowcar2up.gameObject){
            secondslowcar2up.ResetCar();
        }
        if(collision.gameObject == secondmediumcarup.gameObject){
            secondmediumcarup.ResetCar();
        }
        if(collision.gameObject == secondmediumcar2up.gameObject){
            secondmediumcar2up.ResetCar();
        }
        if(collision.gameObject == secondfastcarup.gameObject){
            secondfastcarup.ResetCar();
        }
    }
}
