using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentidoCubo : MonoBehaviour {

    public bool checaSentido = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SentidoCorreto"))
        {
            checaSentido = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SentidoCorreto"))
        {
            checaSentido = false;
        }
    }



}
