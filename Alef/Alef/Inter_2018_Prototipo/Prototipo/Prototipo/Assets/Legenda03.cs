using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legenda03 : MonoBehaviour {

    public Mural03 iniciaLegenda;
    public Animator anim;


    void Update()
    {
        if (iniciaLegenda.abriMural03 == true)
        {
            anim.SetTrigger("Legenda03");
        }
    }
}
