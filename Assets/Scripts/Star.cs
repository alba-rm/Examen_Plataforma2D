using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    BoxCollider2D boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>(); 
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    { 
        if(collider.CompareTag("Player"))
        {
        Destroy(this.gameObject);
        }
        
    }
}
