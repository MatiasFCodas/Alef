using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ComecaFase01 : MonoBehaviour {

    public Animator anim;
    public Animator portaAnim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
            portaAnim.SetTrigger("AbriPorta");
    }

    public void FadeToLevel()
    {
        anim.SetTrigger("FadeOut");
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Level_01C");
    }
}

