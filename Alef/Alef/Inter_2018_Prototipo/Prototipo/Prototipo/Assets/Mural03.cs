using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Mural03 : MonoBehaviour {

    public PuzzleC_02 puzzleMural03;
    public Animator anim;
    public Animator camAnim;
    public GameObject brilho01;
    public GameObject brilho02;
    public GameObject brilho03;
    public GameObject player;
    public CinemachineVirtualCamera cam;
    public bool isComplete03;

    void Update () {

        if (puzzleMural03.puzzleC_02 == true)
        {
            StartCoroutine("NarraMural03");
        }

        if (isComplete03 == true)
        {
            cam.Priority = 9;
            brilho01.SetActive(false);
            brilho02.SetActive(false);
            brilho03.SetActive(false);
        }
    }

    IEnumerator NarraMural03()
    {
        cam.Priority = 12;
        brilho01.SetActive(true);
        brilho02.SetActive(true);
        brilho03.SetActive(true);


        anim.SetTrigger("MuralOn");
        camAnim.SetTrigger("CamMural03");

        yield return new WaitForSeconds(13);

        isComplete03 = true;
        player.SetActive(true);
        player.GetComponent<CharController>().inPuzzle = false;

        StopAllCoroutines();
    }
}
