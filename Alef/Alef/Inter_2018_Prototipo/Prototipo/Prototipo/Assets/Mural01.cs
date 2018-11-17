using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural01 : MonoBehaviour {

    public PuzzleB_01 puzzleTrue;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho;
    public GameObject player;
    public CinemachineVirtualCamera cam;
    public bool isComplete;
    AudioSource narracao;

	void Update () {
        if(puzzleTrue.puzzleB_01 == true)
        {
            StartCoroutine("NarraMural");
            
        }

        if(isComplete == true)
        {
            cam.Priority = 9;
            brilho.SetActive(false);

            player.GetComponent<CharController>().inPuzzle = false;
            player.SetActive(true);
        }
	}

    IEnumerator NarraMural()
    {

        cam.Priority = 12;
        brilho.SetActive(true);


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural");

        yield return new WaitForSeconds(12);

        isComplete = true;

        StopAllCoroutines();

    }

}
