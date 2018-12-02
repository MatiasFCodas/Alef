using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IniciaJogo : MonoBehaviour {

    public GameObject menu;
    public GameObject canvasobj;
    public GameObject animatic;
	public GameObject estrela;
	public GameObject quadro;
    public Animator anim;

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Iniciar()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
		quadro.active = true;
        animatic.SetActive(true);
       anim.SetTrigger("StartAnimatic");
        menu.active = false;
        canvasobj.active = false;
		estrela.active = false;

        //SceneManager.LoadScene("Tutorial");
    }
}
