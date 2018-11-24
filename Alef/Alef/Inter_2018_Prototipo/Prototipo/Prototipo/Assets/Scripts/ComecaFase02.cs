using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComecaFase02 : MonoBehaviour {

    public Animator anim;
    public Camela01 camela;
    
	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        if(camela.isComplete == true)
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
