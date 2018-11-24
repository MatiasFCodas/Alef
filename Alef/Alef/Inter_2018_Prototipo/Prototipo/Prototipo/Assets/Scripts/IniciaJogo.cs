using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IniciaJogo : MonoBehaviour {

    public GameObject animatic;
    public Animator anim;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Iniciar()
    {
        animatic.SetActive(true);
        anim.SetTrigger("StartAnimatic");
    }
}
