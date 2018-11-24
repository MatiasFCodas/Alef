﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerController : MonoBehaviour {



    public Movimento_Petalas_Lerp petal;
    public Totem_Manager totem;


    private void Update()
    {
        ChecaCorreto();
    }



    void ChecaCorreto()
    {
        if (petal.Referencia_01.rotation.y >= 0.7009093 && petal.Referencia_01.rotation.y <= 0.7132504
            && petal.estagio == 1
            && totem.Referencia_01.rotation.y >= 0.7009093 && totem.Referencia_01.rotation.y <= 0.7132504)
        {
            Debug.Log("LiberouPrimeiraParte");
            petal.estagio++;
        }

        if (petal.Referencia_01.rotation.y >= 0.25038 && petal.Referencia_01.rotation.y <= 0.2672383
            && petal.Referencia_02.rotation.y >= -0.0523359 && petal.Referencia_02.rotation.y <= -0.03489958
            && petal.estagio == 2
            && totem.Referencia_01.rotation.y >= 0.5372996 && totem.Referencia_01.rotation.y <= 0.5519369
            && totem.Referencia_02.rotation.y >= -0.0523359 && totem.Referencia_02.rotation.y <= -0.03489958)
        {
            Debug.Log("LiberouSegundaParte");
            petal.estagio++;
        }


            //Petala 01 / Totem 01 //
        if (petal.Referencia_01.rotation.y <= 0.008726558 && petal.Referencia_01.rotation.y >= -0.008726465
            && totem.Referencia_01.rotation.y >= 0.3173046 && totem.Referencia_01.rotation.y <= 0.3338069
            && petal.estagio ==3
            //Petala 02 / Totem 02 //
            && petal.Referencia_02.rotation.y <= -0.4146933 && petal.Referencia_02.rotation.y >= -0.430511
            && totem.Referencia_02.rotation.y >= -0.5664063 && totem.Referencia_02.rotation.y <= -0.5519369
            //Petala 03 / Totem 03 //
            && petal.Referencia_03.rotation.y <= 0.6156614 && petal.Referencia_03.rotation.y >= 0.601815
            && totem.Referencia_03.rotation.y <= 0.6156614 && totem.Referencia_03.rotation.y >= 0.601815)
        {
            Debug.Log("FinalizouTerceiraParte");
        }



    }


}