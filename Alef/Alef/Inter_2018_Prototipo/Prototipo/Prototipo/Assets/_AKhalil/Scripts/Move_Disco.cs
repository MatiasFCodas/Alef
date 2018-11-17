using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Disco : MonoBehaviour {

    /// <Explicação>
    /// 
    /// Este cógigo acessa o componente animator
    /// e ativa os triggers "Direita" e "Esquerda"
    /// podendo assim ser utilizado em todos os 3 
    /// discos da fase 2, desde que todos tenham 
    /// esses triggers com os mesmos nomes
    /// 
    /// Deve ser colocado no tutorial ou de alguma 
    /// forma que o botão para cortar a interação
    /// é o Q, ou decidir um melhor, mas ainda assim
    /// se mantém a necessidade de ensinar tal coisa
    /// para o jogador 
    /// (Khalil - 14:58 - 07/11/2018)
    /// 
    /// </Explicação>

    
    public float timeToNextMove; //Variavel que deve demorar o tempo da animação de movimento do disco

    bool Rodando;

    Animator anim;



    void Start () {
        anim = GetComponent<Animator>();
	}

    void Update() {
        Movimento(); //Foi criado um void para facilitar caso necessite bloquear a movimentação e para organização
    }

    void Movimento()
    {
        if (Input.GetKeyDown(KeyCode.D) && Rodando == false)
        {
            Rodando = true;
            anim.SetTrigger("Direita");
            StartCoroutine(WaitForNextMove());
        }
        if (Input.GetKeyDown(KeyCode.A) && Rodando == false)
        {
            Rodando = true;
            anim.SetTrigger("Esquerda");
            StartCoroutine(WaitForNextMove());
        }
    }

    IEnumerator WaitForNextMove()
    {
        yield return new WaitForSeconds(timeToNextMove);
        Rodando = false;
    }



    




}
