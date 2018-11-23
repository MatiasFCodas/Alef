using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComecaFase02 : MonoBehaviour {

    public Animator anim;
    public Animator portaAnim;
    
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay(Collider other)
    {
            portaAnim.SetTrigger("AbriPorta");
        FadeToLevel();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeOut");
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Level_02");
    }
}
