using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{

    bool hasPackage = false;
    public float delay = 0.5f;  
    void OnCollisionEnter2D(Collision2D collision)
    {
     Debug.Log("Collision with: " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Pacote coletado!");
            hasPackage = true;
            Destroy(collider.gameObject, delay);
        }

        if(collider.tag == "Pessoa" && hasPackage)
        {
            Debug.Log("Pacote Entregue!");
            hasPackage = false;
        }
    }
}
