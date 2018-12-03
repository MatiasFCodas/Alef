using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural05 : MonoBehaviour {

    public FlowerController key;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho01;
    public GameObject brilho02;
    public GameObject brilho03;
    public GameObject player;
 //   public CinemachineVirtualCamera cam;
    public bool isComplete05;
    public bool abriMural05, stopMural;
  //  public AudioSource narracao;
    public AudioSource feedFinal;
    public GameObject porta;

	public GameObject checafases;


    void Update () {
		
        if(key.abriMural05 && !stopMural)
        {
            StartCoroutine("NarraMural05");
            stopMural = true;
        }

        if(isComplete05 == true)
        {
            //    cam.Priority = 9;
            player.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = false;

            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);
        }

	}


    IEnumerator NarraMural05()
    {
        // feedFinal.Play();

        Debug.Log("erro");

        abriMural05 = true;

    //    cam.Priority = 12;

        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);


        player.SetActive(false);
        player.GetComponent<CharController>().inPuzzle = true;

        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural05");

        yield return new WaitForSeconds(25);

      //  cam.Priority = 9;

        isComplete05 = true;

        camAnim.SetTrigger("isComplete05");

        player.SetActive(true);
        player.GetComponent<CharController>().inPuzzle = false;
        porta.GetComponent<BoxCollider>().enabled = true;


		checafases.SetActive(true);
        

        StopAllCoroutines();

    }
}

