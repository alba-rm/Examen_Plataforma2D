using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI puntos;
    
    public void Puntos (int puntosTotales)
    {
        puntos.text = puntosTotales.ToString();
    }
}
