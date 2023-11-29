using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PuntosTotales {get; private set;}
    public HUD hud;
    // Start is called before the first frame update
    public void SumarPuntos(int puntosASumar)
    {
        PuntosTotales += puntosASumar;
        hud.Puntos(PuntosTotales);
        
    }

    public void GameWin()
    {
        //if(Star = 1)
        {
        Debug.Log("YouWin");
        SceneManager.LoadScene(2);
        }
    }
}
