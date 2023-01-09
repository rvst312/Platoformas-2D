using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        if (puntos==3)
        {
            
            SceneManager.LoadScene(2);
        }
    }
}
