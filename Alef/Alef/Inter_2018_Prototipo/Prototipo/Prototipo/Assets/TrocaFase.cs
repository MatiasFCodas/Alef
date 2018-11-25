using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaFase : MonoBehaviour {

    public Animator anim;
    public Animator portaAnim;
    public Animator ilhaAnim;

    public Checa_Fase key;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && key.ok4 == true)
        {
            ilhaAnim.SetTrigger("EntraIlha");
            FadeToLevel();
        }

        else if (Input.GetKeyDown(KeyCode.E) && key.ok == true)
        {
            portaAnim.SetTrigger("AbriPorta");
            FadeToLevel();

        }


    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeOut");
    }

    void FadeComplete()
    {
        if (key.ok4 == true)
        {
            SceneManager.LoadScene("Ilha");
        }

       else if (key.ok == true)
        {
            SceneManager.LoadScene("Level_01");
        }

    }
}
