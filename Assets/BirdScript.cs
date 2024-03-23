using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapForce;

    // Start is called before the first frame update
    void Start()
    {
       flapForce = 14;
       rb.gravityScale = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            rb.velocity = Vector2.up * flapForce;
        }


    }
}
