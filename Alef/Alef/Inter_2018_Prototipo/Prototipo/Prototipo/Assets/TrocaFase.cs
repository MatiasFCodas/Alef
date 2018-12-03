using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaFase : MonoBehaviour {

    public Animator anim;
    public Animator portaAnim;
    public Animator ilhaAnim;

    public Checa_Fase key;

    public GameObject instrucao;

    void OnTriggerStay(Collider other)
    {
        instrucao.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E) && key.ok4 == true )
        {
            ilhaAnim.SetTrigger("EntraIlha");
            FadeToLevel();
            instrucao.SetActive(false);

        }

        else if (Input.GetKeyDown(KeyCode.E) && key.ok3 == true)
        {
            FadeToLevel();
            instrucao.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.E) && key.ok == true)
        {
            portaAnim.SetTrigger("AbriPorta");
            FadeToLevel();
            instrucao.SetActive(false);

        }


    }

     void OnTriggerExit(Collider other)
    {
        instrucao.SetActive(false);

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

        else if(key.ok3 == true)
        {
            SceneManager.LoadScene("Level_03");
        }

       else if (key.ok == true)
        {
            SceneManager.LoadScene("Level_01");
        }

    }
}
