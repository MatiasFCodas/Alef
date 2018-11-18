using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legenda01 : MonoBehaviour {

    public Mural01 iniciaLegenda;
    public Animator anim;
        

	void Update () {
		if(iniciaLegenda.abriMural01 == true)
        {
            anim.SetTrigger("Legenda01");
        }
	}
}
