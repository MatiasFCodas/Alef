using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Fim_da_Fase02 : MonoBehaviour {


    public Animator anim;
    public Checa_Fase key;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && key.fase03Liberado == true)
            FadeToLevel();
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeOut");
    }

    public void FadeComplete()
    {
        SceneManager.LoadScene("Praça");
    }

}
