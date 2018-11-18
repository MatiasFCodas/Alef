using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural01 : MonoBehaviour {

    public PuzzleB_01 puzzleMural01;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho01;
    public GameObject brilho02;
    public GameObject brilho03;
    public GameObject player;
    public CinemachineVirtualCamera cam;
    public bool isComplete01;
    public bool abriMural01;

	void Update () {

        if (puzzleMural01.puzzleB_01 == true)
        {
            StartCoroutine("NarraMural01");
            
        }

        if(isComplete01 == true)
        {
            cam.Priority = 9;
            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);

            player.GetComponent<CharController>().inPuzzle = false;
            player.SetActive(true);
        }


	}

    IEnumerator NarraMural01()
    {
        abriMural01 = true;

        cam.Priority = 12;
        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural01");

        yield return new WaitForSeconds(10);

        isComplete01 = true;

        StopAllCoroutines();

    }

}
