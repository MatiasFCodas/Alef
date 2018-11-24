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
    /// Possivel fazer a ativação das portas
    /// por aqui 
    /// (Khalil - 22:45 - 07/11/2018)
    /// 
    /// </Explicação>
    
    
    public CinemachineVirtualCamera cam;

    public GameObject player;
    public GameObject inicio;
    public GameObject face;
    public GameObject bloqueios;
    public GameObject bloqueiosFinaizado;
    public GameObject puzzleDisco;

    public static float finalizado = 0;

    public AudioSource feed;

    public move2 movCubo;

    public GameObject cubo;

    public GameObject fimOutrosPuzzles_01;
    public GameObject fimOutrosPuzzles_02;


    public GameObject proprioFimPuzzle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {

            movCubo.ResetPosistion();

            
            cubo.GetComponent<move2>().left = false;
            cubo.GetComponent<move2>().right = false;
            cubo.GetComponent<move2>().up = false;
            cubo.GetComponent<move2>().down = false;
            cubo.transform.rotation = cubo.GetComponent<move2>().inicioRot;
            cubo.transform.position = cubo.GetComponent<move2>().inicio;




            player.SetActive(true);
            puzzleDisco.SetActive(true);
            player.GetComponent<CharController>().inPuzzle = false;
            cubo.GetComponent<move2>().enabled = false;
            
            cam.Priority = 9;


            fimOutrosPuzzles_01.SetActive(true);
            fimOutrosPuzzles_02.SetActive(true);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face") && other.gameObject == face)
        {
            finalizado++;
            cam.Priority = 9;

            feed.Play();

            player.SetActive(true);
            inicio.SetActive(false);
            bloqueios.SetActive(false);
            bloqueiosFinaizado.SetActive(true);
            puzzleDisco.SetActive(true);

            fimOutrosPuzzles_01.SetActive(true);
            fimOutrosPuzzles_02.SetActive(true);

            player.GetComponent<CharController>().inPuzzle = false;
            face.GetComponent<BoxCollider>().enabled = false;
            movCubo.canMove = false;

            proprioFimPuzzle.SetActive(false);


        }
    }

}
