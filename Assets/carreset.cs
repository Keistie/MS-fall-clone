using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carreset : MonoBehaviour
{

    public Rigidbody2D car;
    Vector3 carStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        carStartPosition = car.transform.localPosition;
    }

    public void ResetCar(){
        car.transform.localPosition = carStartPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
