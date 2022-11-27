using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//detectar el suelo 
public class GroundDetector_Trigger : MonoBehaviour
{
    public bool grounded;

    private void OnTrriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTrriggerExit2D(Collider2D collision)
    {
        grounded = false;

    }
}

