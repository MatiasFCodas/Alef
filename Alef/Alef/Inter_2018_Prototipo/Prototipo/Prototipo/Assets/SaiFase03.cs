using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaiFase03 : MonoBehaviour {

    public Animator anim;
    public Animator animD;
    public Animator animE;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            FadeToLevel();
            animD.SetTrigger("AbriPortaD");
            animE.SetTrigger("AbriPortaE");
        }
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
