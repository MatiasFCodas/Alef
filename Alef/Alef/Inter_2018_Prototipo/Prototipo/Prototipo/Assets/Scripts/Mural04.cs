using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural04 : MonoBehaviour {

    public Checa_Chave puzzleMural04;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho01;
    public GameObject brilho02;
    public GameObject brilho03;
    public GameObject player;
    public GameObject legenda04;
    public GameObject legenda05;
    public CinemachineVirtualCamera cam;
    public bool isComplete04;
    public bool abriMural04;
    public AudioSource narracao;

    bool stopMural;

    void Update()
    {

        if (puzzleMural04.mural04 == true && !stopMural)
        {
            stopMural = true;
            narracao.Play(5);
            StartCoroutine("NarraMural04");
        }

        if (isComplete04 == true)
        {
            cam.Priority = 9;

            player.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = false;

            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);
        }
    }

    IEnumerator NarraMural04()
    {
        abriMural04 = true;

        cam.Priority = 12;
        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);

        player.SetActive(false);
        player.GetComponent<CharController>().inPuzzle = true;


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural04");


        yield return new WaitForSeconds(25);

        cam.Priority = 9;

        isComplete04 = true;

        player.SetActive(true);
        player.GetComponent<CharController>().inPuzzle = false;

        StopAllCoroutines();

    }


}

