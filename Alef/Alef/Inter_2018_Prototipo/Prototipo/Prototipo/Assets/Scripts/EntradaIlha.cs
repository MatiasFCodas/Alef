using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntradaIlha : MonoBehaviour {

    public Animator anim;
    public Animator ilhaAnim;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            ilhaAnim.SetTrigger("EntraIlha");
        }
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeOut_Ilha");
    }

     void FadeCompleteIlha()
    {
            SceneManager.LoadScene("Ilha");
        
    }
}
