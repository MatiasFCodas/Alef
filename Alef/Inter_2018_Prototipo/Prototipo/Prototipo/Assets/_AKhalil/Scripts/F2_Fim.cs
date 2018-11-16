using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class F2_Fim : MonoBehaviour
{


    /// <Explicação>
    /// 
    /// Script aonde checa a colisão da face
    /// do cubo com o tile correto de chão e
    /// volta a "Priority" da camera para "9"
    /// desativando a área de colisão para
    /// acessar o cubo e também reativa o player
    /// 
    /// É possível que seja necessária uma
    /// segunda variável que verifique o
    /// sentido do cubo
    /// (Khalil - 22:43 - 07/11/2018)
    /// 
    /// Possivel fazer a ativação das portas
    /// por aqui 
    /// (Khalil - 22:45 - 07/11/2018)
    /// 
    /// </Explicação>
    
    
    public CinemachineVirtualCamera cam;

    public GameObject player;
    public GameObject inicio;
    public GameObject face;
    public GameObject cuboCerto;

    public AudioSource feed;

    public move2 movCubo;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face") && other.gameObject == cuboCerto)
        {            
            cam.Priority = 9;

            feed.Play();

            player.SetActive(true);
            inicio.SetActive(false);
            
            player.GetComponent<CharController>().inPuzzle = false;
            face.GetComponent<BoxCollider>().enabled = false;
            movCubo.canMove = false;
        }
    }

}
