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
    static public bool abriMural04;

    void Update()
    {

        if (puzzleMural04.mural04 == true)
        {
            StartCoroutine("NarraMural04");
        }

        if (isComplete04 == true)
        {
            cam.Priority = 9;

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


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural04");

        legenda04.SetActive(true);

        yield return new WaitForSeconds(15);

        legenda04.SetActive(false);
        legenda05.SetActive(true);

        yield return new WaitForSeconds(10);

        legenda05.SetActive(false);

        isComplete04 = true;

        player.SetActive(true);
        player.GetComponent<CharController>().inPuzzle = false;

        StopAllCoroutines();
    }
}

