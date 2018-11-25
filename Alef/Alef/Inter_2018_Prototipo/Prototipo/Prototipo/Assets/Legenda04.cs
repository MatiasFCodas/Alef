using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legenda04 : MonoBehaviour {

    public Mural04 iniciaLegenda;
    public Animator anim;


	void Update () {
		
        if(iniciaLegenda.abriMural04 == true)
        {
            anim.SetTrigger("Legenda04");
        }

	}
}
