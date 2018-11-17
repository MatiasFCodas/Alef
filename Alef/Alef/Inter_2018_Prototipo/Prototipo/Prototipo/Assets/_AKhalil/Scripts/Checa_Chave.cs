using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checa_Chave : MonoBehaviour {

    /// <Explicação>
    /// 
    /// Verifica se as chaves foram habilitadas
    /// e mais tarde abre as portas ou não
    /// 
    /// </Explicação>

    
    public Luz ch1;
    public Luz ch2;
    public Luz ch3;

    void Update()
    {
        PassagemNormal();
        PortaSecreta();
    }


    void PortaSecreta()
    {
        if (ch1.chavePortaNormal == true)
        {
            Debug.Log("chave1foi");//substituir pela boolean de permissão da porta
        }
        if (ch2.chavePortaNormal == true)
        {
            Debug.Log("chave2foi");//substituir pela boolean de permissão da porta
        }
        if (ch3.chavePortaNormal == true)
        {
            Debug.Log("chave3foi");//substituir pela boolean de permissão da porta
        }
    }

    void PassagemNormal()
    {
        if (ch1.chavePortaSecreta == true)
        {
            Debug.Log("ChaveSecreta1 ativa");//substituir pela boolean de permissão da porta
        }


        if (ch2.chavePortaSecreta == true)
        {
            Debug.Log("ChaveSecreta2 ativa");//substituir pela boolean de permissão da porta
        }


        if (ch3.chavePortaSecreta == true)
        {
            Debug.Log("ChaveSecreta3 ativa");//substituir pela boolean de permissão da porta
        }
    }


}
