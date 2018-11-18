using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural02 : MonoBehaviour {

    public PuzzleB_02 puzzleMural02;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho01;
    public GameObject brilho02;
    public GameObject brilho03;
    public GameObject player;
    public CinemachineVirtualCamera cam;
    public bool isComplete02;

 
	void Update () {

        if (puzzleMural02.puzzleB_02 == true)
        {
            StartCoroutine("NarraMural02");
        }

        if (isComplete02 == true)
        {
            cam.Priority = 9;
            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);

            player.GetComponent<CharController>().inPuzzle = false;
            player.SetActive(true);
        }
    }

    IEnumerator NarraMural02()
    {
        cam.Priority = 12;
        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural02");

        yield return new WaitForSeconds(15);

        isComplete02 = true;

        StopAllCoroutines();
    }
}
