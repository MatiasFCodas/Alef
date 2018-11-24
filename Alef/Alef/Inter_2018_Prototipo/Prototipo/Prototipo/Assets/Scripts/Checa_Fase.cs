using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checa_Fase : MonoBehaviour {

     Checa_Chave puzzleCompleto;
    public static  int fase03Liberado = 0;
    public GameObject camela;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(puzzleCompleto.mural04 == true)
        {
            fase03Liberado = 1;
        }

        if(fase03Liberado == 1)
        {
            camela.SetActive(true);
        }



	}
}
