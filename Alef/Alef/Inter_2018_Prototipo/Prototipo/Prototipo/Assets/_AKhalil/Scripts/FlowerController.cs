using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FlowerController : MonoBehaviour {



    public Movimento_Petalas_Lerp petal;
    public Totem_Manager totem;

    public GameObject petalasManager;
    public GameObject totemManager;
    public CinemachineVirtualCamera cam;
    public GameObject player;

    public GameObject inicioPuzzle;

    public bool abriMural05;

    public AudioSource feed01;
    public AudioSource feed02;
    public AudioSource feed03;

    public GameObject instrucoes;

    


    public GameObject brilho_01;
    public GameObject brilho_02;
    public GameObject brilho_03;


    bool fim_01;
    bool fim_02;
    bool fim_03;

    private void Update()
    {
        ChecaCorreto();
    }



    void ChecaCorreto()
    {
        if (petal.Referencia_01.rotation.y >= 0.7009093 && petal.Referencia_01.rotation.y <= 0.7132504
            && petal.estagio == 1
            && totem.Referencia_01.rotation.y >= 0.7009093 && totem.Referencia_01.rotation.y <= 0.7132504
            && !fim_01)
        {
            fim_01 = true;
            StartCoroutine(Finalizador_01());
        }

        if (petal.Referencia_01.rotation.y >= 0.25038 && petal.Referencia_01.rotation.y <= 0.2672383
            && petal.Referencia_02.rotation.y >= -0.0523359 && petal.Referencia_02.rotation.y <= -0.03489958
            && petal.estagio == 2
            && totem.Referencia_01.rotation.y >= 0.5372996 && totem.Referencia_01.rotation.y <= 0.5519369
            && totem.Referencia_02.rotation.y >= -0.0523359 && totem.Referencia_02.rotation.y <= -0.03489958
            && !fim_02)
        {
            fim_02 = true;
            StartCoroutine(Finalizador_02());
            Debug.Log("LiberouSegundaParte");
            feed02.PlayDelayed(1);
            petal.estagio++;
        }


            //Petala 01 / Totem 01 //
        if (petal.Referencia_01.rotation.y <= 0.008726558 && petal.Referencia_01.rotation.y >= -0.008726465
            && totem.Referencia_01.rotation.y >= 0.3173046 && totem.Referencia_01.rotation.y <= 0.3338069
            && petal.estagio ==3
            //Petala 02 / Totem 02 //
            && petal.Referencia_02.rotation.y <= -0.4146933 && petal.Referencia_02.rotation.y >= -0.430511
            && totem.Referencia_02.rotation.y >= -0.5664063 && totem.Referencia_02.rotation.y <= -0.5519369
            //Petala 03 / Totem 03 //
            && petal.Referencia_03.rotation.y <= 0.6156614 && petal.Referencia_03.rotation.y >= 0.601815
            && totem.Referencia_03.rotation.y <= 0.6156614 && totem.Referencia_03.rotation.y >= 0.601815 
            && !fim_03)
        {
            fim_03 = true;
            StartCoroutine(Finalizador_03());
        }



    }


    IEnumerator Finalizador_01()
    {

        Debug.Log("LiberouPrimeiraParte");
        feed01.PlayDelayed(1);
        petal.estagio++;
        brilho_01.SetActive(true);
        yield return new WaitForSeconds(5);
    }

    IEnumerator Finalizador_02()
    {
        Debug.Log("LiberouSegundaParte");
        feed02.PlayDelayed(1);
        petal.estagio++;
        brilho_02.SetActive(true);
        yield return new WaitForSeconds(5);
    }

    IEnumerator Finalizador_03()
    {
        Debug.Log("LiberouTerceiraParte");
        instrucoes.SetActive(false);        
        inicioPuzzle.SetActive(false);
        cam.Priority = 9;
        brilho_03.SetActive(true);
        yield return new WaitForSeconds(1);
        petalasManager.GetComponent<Movimento_Petalas_Lerp>().enabled = false;
        totemManager.GetComponent<Totem_Manager>().enabled = false;
        abriMural05 = true;
    }


}
