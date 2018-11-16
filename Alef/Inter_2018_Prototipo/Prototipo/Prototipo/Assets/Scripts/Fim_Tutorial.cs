using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim_Tutorial : MonoBehaviour {

    public Animator animD;
    public Animator animE;
    public Animator animator;
    public GameObject instrucoes03;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


     void OnTriggerStay(Collider other)
    {
        instrucoes03.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player")){
            instrucoes03.SetActive(false);
            animD.SetTrigger("AbriPorta");
            animE.SetTrigger("AbriPorta");
            FadeToLevel();
        }
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }

    public void FadeComplete()
    {
        SceneManager.LoadScene("Praça");
    }
}
