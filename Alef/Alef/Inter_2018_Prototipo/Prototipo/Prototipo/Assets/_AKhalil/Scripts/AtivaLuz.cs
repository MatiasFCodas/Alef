using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaLuz : MonoBehaviour {


    public GameObject Totem_01, Totem_02;


    public GameObject Particula_01, Particula_02;

    public GameObject Checker_01;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Totem_01)
        {
            Checker_01.SetActive(true);
            Particula_01.SetActive(true);
        }

        if(other.gameObject == Totem_02)
        {
            Checker_01.SetActive(true);
            Particula_02.SetActive(true);
        }
    }







    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Totem_01 || Totem_02.gameObject == Totem_02)
        {
            Particula_01.SetActive(false);
            Particula_02.SetActive(false);
            Checker_01.SetActive(false);
        }
    }



}
