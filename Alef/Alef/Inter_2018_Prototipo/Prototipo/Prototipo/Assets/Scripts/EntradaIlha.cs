using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntradaIlha : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
            FadeToLevel();
    }

    private void FadeToLevel()
    {
        anim.SetTrigger("FadeOut");
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("Ilha");
    }
}
