using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltaMenu : MonoBehaviour {

    public GameObject creditos;
    public GameObject image01;
    public GameObject image02;
    public GameObject botaoJogar;
    public GameObject botaoCreditos;
    public GameObject botaoVoltar;

    public void Voltar()
    {
        creditos.SetActive(false);
        botaoVoltar.SetActive(false);

        image01.SetActive(true);
        image02.SetActive(true);
        botaoJogar.SetActive(true);
        botaoCreditos.SetActive(true);

    }
}
