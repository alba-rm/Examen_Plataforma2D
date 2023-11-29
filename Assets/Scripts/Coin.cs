using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public int valor = 1;
    public GameManager gameManager;
    
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>(); 
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    { 
        if(collider.CompareTag("Player"))
        {
        gameManager.SumarPuntos(valor);
        Destroy(this.gameObject);
        }
         
    }
}
