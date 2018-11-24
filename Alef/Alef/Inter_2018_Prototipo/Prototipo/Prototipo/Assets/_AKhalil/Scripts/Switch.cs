using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {


    /// <Explicação>
    /// 
    /// Nesse script é aonde se faz a interação para que o 
    /// puzzle seja ativado ou desativado (caso seja 
    /// apertado a tecla "Q")
    /// 
    /// As booleans foram criadas para suprir a necessidade 
    /// da criação de 3 scripts para permitir a movimentação 
    /// dos discos, permitindo assim que caso alguma das 
    /// movimentações deva ser bloqueada é necessário somente
    /// tornar as booleans falsas
    /// 
    /// </Explicação>
    


    public bool m_Aro01, m_Aro02, m_Aro03;

    public GameObject player;

    public GameObject aro_01;
    public GameObject aro_02;
    public GameObject aro_03;

    public GameObject finaisDosCubos_01;
    public GameObject finaisDosCubos_02;
    public GameObject finaisDosCubos_03;


    void Start()
    {
        aro_01.GetComponent<Move_Disco>().enabled = false;
        aro_02.GetComponent<Move_Disco>().enabled = false;
        aro_03.GetComponent<Move_Disco>().enabled = false;
    }

    void Update()
    {
        SaiDoPuzzle();
    }

    void SaiDoPuzzle()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.GetComponent<CharController>().inPuzzle = false; 
            player.SetActive(true);


            aro_01.GetComponent<Move_Disco>().enabled = false;
            aro_02.GetComponent<Move_Disco>().enabled = false;
            aro_03.GetComponent<Move_Disco>().enabled = false;

            finaisDosCubos_01.SetActive(true);
            finaisDosCubos_02.SetActive(true);
            finaisDosCubos_03.SetActive(true);
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {

            finaisDosCubos_01.SetActive(false);
            finaisDosCubos_02.SetActive(false);
            finaisDosCubos_03.SetActive(false);

            player.GetComponent<CharController>().inPuzzle = true; //desativa o jogador        

            if (m_Aro01 == true)
            { 
                aro_01.GetComponent<Move_Disco>().enabled = true; //ativa o script de movimentação da peça 1
            }


            if (m_Aro02 == true)
            {
                aro_02.GetComponent<Move_Disco>().enabled = true; //ativa o script de movimentação da peça 2
            }


            if (m_Aro03 == true)
            {
                aro_03.GetComponent<Move_Disco>().enabled = true; //ativa o script de movimentação da peça 3
            }
        }
    }
}
