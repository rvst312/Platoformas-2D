using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recolectorMonedas : MonoBehaviour
{
    public puntuaje puntuaje;
    private void OnTriggerEnter2D(Collider2D other) {
        puntuaje.SumarPuntos();
        Destroy(other.gameObject);
    }
}
