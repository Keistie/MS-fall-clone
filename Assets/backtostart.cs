using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backtostart : MonoBehaviour
{
    public playerreset player;

    public playerreset player2;

    public Text scoretext1;

    public Text scoretext2;

    //public float scorenumber = 0;

    public int Score1; 

    public int Score2;

    public void Start()
    {
       // scorenumber = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject == player.gameObject){
            player.ResetPlayer();
            AddScore1();
        }
        if(collision.gameObject == player2.gameObject){
            player2.ResetPlayer();
            AddScore2();
        }
    }

    public void AddScore1(){
        Score1++;
        scoretext1.text = Score1.ToString();
    }

    public void AddScore2(){
        Score2++;
        scoretext2.text = Score2.ToString();
    }
}
