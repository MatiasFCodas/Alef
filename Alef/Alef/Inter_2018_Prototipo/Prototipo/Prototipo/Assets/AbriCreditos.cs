using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbriCreditos : MonoBehaviour {

    public GameObject creditos;
    public GameObject image01;
    public GameObject image02;
    public GameObject botaoJogar;
    public GameObject botaoCreditos;
    public GameObject botaoVoltar;

    public void Creditos()
    {
        creditos.SetActive(true);
        botaoVoltar.SetActive(true);

        image01.SetActive(false);
        image02.SetActive(false);
        botaoJogar.SetActive(false);
        botaoCreditos.SetActive(false);

    }
}
