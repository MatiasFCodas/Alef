using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legenda02 : MonoBehaviour {

    public Mural02 iniciaLegenda;
    public Animator anim;


    void Update()
    {
        if (iniciaLegenda.abriMural02 == true)
        {
            anim.SetTrigger("Legenda02");
        }
    }
}
