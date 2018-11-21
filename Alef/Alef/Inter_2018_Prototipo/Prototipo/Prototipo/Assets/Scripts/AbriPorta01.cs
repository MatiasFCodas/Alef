using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriPorta01 : MonoBehaviour {

   
    public GameObject puzzle01;
    public GameObject puzzle02;
    public GameObject puzzle03;



    public Animator anim01;
    public Animator anim02;
    public Animator anim03;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (puzzle01.GetComponent<PuzzleA_02>().puzzleA_02 == true)
        {
            anim01.SetTrigger("AbriPorta01");
           
        }

        if (puzzle02.GetComponent<PuzzleB_02>().puzzleB_02 == true)
        {
            anim02.SetTrigger("AbriPorta02");   

        }

        if (puzzle03.GetComponent<PuzzleC_02>().puzzleC_02 == true)
        {
            anim03.SetTrigger("AbriPorta03");

        }

    }

}
