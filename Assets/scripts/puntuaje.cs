using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntuaje : MonoBehaviour
{
    public TextMeshProUGUI textoPuntos;
    private int puntos;
    void Start()
    {
        puntos = 0; 
    } 

    public void SumarPuntos(){
        puntos++;
        // Debug.Log(puntos);
        textoPuntos.text = "POINTS: " + puntos.ToString();
    }
}
