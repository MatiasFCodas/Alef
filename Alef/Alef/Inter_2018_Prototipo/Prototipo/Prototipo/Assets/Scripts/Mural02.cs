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
    public CinemachineFreeLook playerCam;
    public bool isComplete02;
    public bool abriMural02;

    private bool jafoiporra;

	void Update () {

        if (puzzleMural02.puzzleB_02 == true && !jafoiporra)
        {
            StartCoroutine("NarraMural02");
            jafoiporra = true;
        }

        if (isComplete02 == true)
        {

            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);
        }
    }

    IEnumerator NarraMural02()
    {

        abriMural02 = true;

        cam.Priority = 12;

        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural02");

        yield return new WaitForSeconds(14);

        isComplete02 = true;

        cam.Priority = 9;

        player.SetActive(true);
        player.GetComponent<CharController>().inPuzzle = false;
     //   gameObject.GetComponent<Mural02>().enabled = false;

        StopAllCoroutines();
    }
}
