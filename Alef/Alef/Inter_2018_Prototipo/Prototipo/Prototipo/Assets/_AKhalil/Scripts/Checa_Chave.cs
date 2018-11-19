using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checa_Chave : MonoBehaviour {

    /// <Explicação>
    /// 
    /// Verifica se as chaves foram habilitadas
    /// e mais tarde abre as portas
    /// 
    /// </Explicação>

    
    public Luz ch1;
    public Luz ch2;
    public Luz ch3;

    public bool mural04;
    
    

    void Update()
    {
        if (F2_Fim.finalizado >= 3)
        {
            PassagemNormal();
        }
        PortaSecreta();
    }


    void PassagemNormal()
    {
        if (ch1.chavePortaNormal == true && ch2.chavePortaNormal == true && ch3.chavePortaNormal == true)
        {
            mural04 = true;
            Debug.Log("chave1foi");//substituir pela boolean de permissão da porta
        }
    }

    void PortaSecreta()
    {
        if (ch1.chavePortaSecreta == true && ch2.chavePortaSecreta == true && ch3.chavePortaSecreta == true)
        {
            Debug.Log("ChaveSecreta1 ativa");//substituir pela boolean de permissão da porta
        }
    }


}
