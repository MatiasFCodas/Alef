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

    public GameObject porta;


    public GameObject inicioCubo_01;
    public GameObject inicioCubo_02;
    public GameObject inicioCubo_03;
    public GameObject inicioAro_01;
    public GameObject inicioAro_02;
    public GameObject inicioAro_03;

    public GameObject som;
    public GameObject instrucoes;

    

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

            porta.GetComponent<BoxCollider>().enabled = true;
            mural04 = true;
            som.SetActive(false);
            instrucoes.SetActive(false);
            inicioCubo_01.SetActive(false);
            inicioCubo_02.SetActive(false);
            inicioCubo_03.SetActive(false);
            inicioAro_01.SetActive(false);
            inicioAro_02.SetActive(false);
            inicioAro_03.SetActive(false);

            /// <Expicação>
            ///
            /// Coloca Aqui a ativação da animação do mural/Movimentação da câmera para visualizar o mural
            /// 
            /// </Explicação>
        }
    }

    void PortaSecreta()
    {
        if (ch1.chavePortaSecreta == true && ch2.chavePortaSecreta == true && ch3.chavePortaSecreta == true)
        {
         //   Debug.Log("ChaveSecreta1 ativa");//substituir pela boolean de permissão da porta
        }
    }
}
