using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checa_Fase : MonoBehaviour {

     Checa_Chave puzzleCompleto;
    static public  bool fase03Liberado;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(puzzleCompleto.mural04 == true)
        {
            fase03Liberado = true;
        }

	}
}
