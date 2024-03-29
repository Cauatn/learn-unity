using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour


{

    public float moveSpeed = 8.0f;
    public float turnSpeed = 200.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Movimentation();
        
    }

    void Movimentation() {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount,0);
    }
}
