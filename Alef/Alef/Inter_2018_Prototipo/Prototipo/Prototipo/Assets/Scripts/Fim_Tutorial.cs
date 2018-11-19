using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fim_Tutorial : MonoBehaviour {

    public GameObject instrucao05;
    public Animator animD;
    public Animator animE;
    public Animator animator;
    public bool  ativaInstrucao;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


     void OnTriggerStay(Collider other)
    {
        instrucao05.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player")){
            instrucao05.SetActive(false);
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

    public void InstrucaoAparece()
    {
        ativaInstrucao = true;
    }
}
