using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totem_Manager : MonoBehaviour
{

    /// <Explicação>
    /// 
    /// 
    /// 
    /// </Explicação>
    
    
    [HideInInspector]public Transform startingPoint;
    [HideInInspector]public Transform finishingPoint;

    // Velocidade em que o totem se move no Lerp
    [HideInInspector]public float speed = 0.125f;


    // Referencias dos totens que irão girar
    // Caso haja a necessidade de refazer as associações apagar "[HideInInspector]"
    public Transform Alterado_01;
    public Transform Alterado_02;
    public Transform Alterado_03;
    public Transform Referencia_01;
    public Transform Referencia_02;
    public Transform Referencia_03;



    // Possíveis posições do primeiro (1º) totem
    public float t1Pos1, t1Pos2, t1Pos3;
    public float t1PosN1, t1PosN2, t1PosN3;


    // Possíveis posições do segundo (2º) totem
    public float t2Pos1, t2Pos2;
    public float t2PosN1, t2PosN2;


    // Possíveis posições do terceiro (3º) totem
    public float t3Pos1;
    public float t3PosN1;


    // Diz qual dos totens está selecionado no momento, alterando assim o quanto o totem se movimenta
    // e assim também qual deles se movimentará
    public float totemSelecionado;


    // Variaveis que dizem quanto o totem vai se mover, sempre são alteradas caso mude de totem 
    // por conta da função "Ajusta Posições" recebendo os valores que forem preenchidos nas variáveis
    float Pos1, Pos2, Pos3; 
    float PosNeg1, PosNeg2, PosNeg3;

    
    // Diz qual a posição das possibilidades o totem está, auxiliando o algoritmo a saber qual movimento deve ser
    // feito a seguir
    public int modo;


    // Variaveis para armazenar em qual ponto a variavel "modo" se encontrava antes de trocar para outro 
    // totem, evitando assim que os totens se movam além do que é permitido
    int modoArmazenado01;
    int modoArmazenado02;
    int modoArmazenado03;


    // Variavel que impede o jogador de spammar movimentos, permitindo assim que as "animações" de cada petala
    // sejam finalizadas evitando a flicagem das mesmas
    [HideInInspector] public float tempoArmazenado;
    [HideInInspector] public float tempoAdicionado = 1.5f;



    public GameObject brilho_01_Totem;
    public GameObject brilho_02_Totem;
    public GameObject brilho_03_Totem;




    [HideInInspector] public bool ativaTotem;



    // Referencia para a variável "estagio" a qual diz quantos totens/petalas o jogador já liberou
    // sendo assim o quanto ele avançou no level
    public Movimento_Petalas_Lerp petal;

    

    void Update()
    {
        GiraTotem();        
        petal.petalaSelecionada = totemSelecionado;
        totemSelecionado = petal.petalaSelecionada;                
    }



    void GiraTotem()
    {
        Quaternion newFinishingPoint = finishingPoint.rotation;
        Quaternion smootheredThing = Quaternion.Lerp(startingPoint.rotation, newFinishingPoint, speed);
        startingPoint.rotation = smootheredThing;

        if (totemSelecionado == 1)
        {
            modo = modoArmazenado01;
            AjustaPosicoes(t1Pos1, t1Pos2, t1Pos3, t1PosN1, t1PosN2, t1PosN3);
            MoveTotem(1);
            modoArmazenado01 = modo;
            startingPoint = Alterado_01;
            finishingPoint = Referencia_01;
            if (petal.ativaPetalas == false)
            {
                brilho_01_Totem.SetActive(true);
                brilho_02_Totem.SetActive(false);
                brilho_03_Totem.SetActive(false);
            }
            if (ativaTotem == true)
            {
                petal.Brilho_01_Petala.SetActive(false);
                petal.Brilho_02_Petala.SetActive(false);
                petal.Brilho_03_Petala.SetActive(false);
            }
            return;
        }

        if (totemSelecionado == 2)
        {
            modo = modoArmazenado02;
            AjustaPosicoes(t2Pos1, t2Pos2, 0, t2PosN1, t2PosN2, 0);
            MoveTotem(2);
            modoArmazenado02 = modo;
            startingPoint = Alterado_02;
            finishingPoint = Referencia_02;
            if (petal.ativaPetalas == false)
            {
                brilho_01_Totem.SetActive(false);
                brilho_02_Totem.SetActive(true);
                brilho_03_Totem.SetActive(false);
            }
            if (ativaTotem == true)
            {
                petal.Brilho_01_Petala.SetActive(false);
                petal.Brilho_02_Petala.SetActive(false);
                petal.Brilho_03_Petala.SetActive(false);
            }
            return;
        }

        if (totemSelecionado == 3)
        {
            modo = modoArmazenado03;
            AjustaPosicoes(t3Pos1, 0, 0, t3PosN1, 0, 0);
            MoveTotem(3);
            modoArmazenado03 = modo;
            startingPoint = Alterado_03;
            finishingPoint = Referencia_03;
            if (petal.ativaPetalas == false)
            {
                brilho_01_Totem.SetActive(false);
                brilho_02_Totem.SetActive(false);
                brilho_03_Totem.SetActive(true);
            }
            if (ativaTotem == true)
            {
                petal.Brilho_01_Petala.SetActive(false);
                petal.Brilho_02_Petala.SetActive(false);
                petal.Brilho_03_Petala.SetActive(false);
            }
            return;
        }


        if (petal.estagio == 2) // Alteração entre os totens caso o jogador esteja no nivel 2
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time >= tempoArmazenado) //===== CIMA =====//
            {

                tempoArmazenado = Time.time + tempoAdicionado;
                if (totemSelecionado >= 2) totemSelecionado--;
                else totemSelecionado = 2;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time >= tempoArmazenado) //===== BAIXO =====//
            {
                tempoArmazenado = Time.time + tempoAdicionado;
                if (totemSelecionado <= 1) totemSelecionado++;
                else totemSelecionado = 1;
            }
        }// Alteração entre os totens caso o jogador esteja no nivel 2

        if (petal.estagio == 3)// Alteração entre os totens caso o jogador esteja no nivel 3
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time >= tempoArmazenado) //===== CIMA =====//
            {
                tempoArmazenado = Time.time + tempoAdicionado;
                if (totemSelecionado >= 2) totemSelecionado--;
                else totemSelecionado = 3;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time >= tempoArmazenado) //===== BAIXO =====//
            {
                tempoArmazenado = Time.time + tempoAdicionado;
                if (totemSelecionado <= 2) totemSelecionado++;
                else totemSelecionado = 1;
            }
        }// Alteração entre os totens caso o jogador esteja no nivel 3
    }



    void AjustaPosicoes(float val1,float val2,float val3, float valNeg1,float valNeg2, float valNeg3)
    {
        Pos1 = val1;
        Pos2 = val2;
        Pos3 = val3;

        PosNeg1 = valNeg1;
        PosNeg2 = valNeg2;
        PosNeg3 = valNeg3;
    }



    void MoveTotem(int qualTotem) //Dependendo de quanto o jogador avançou na fase ele tem um certo limite
    {
        if (Input.GetKeyDown(KeyCode.A)/* && Time.time >= tempoArmazenado*/ && ativaTotem == true)
        {
            tempoArmazenado = Time.time + tempoAdicionado;
            speed = 0.05f;

            if (modo == -3)
            {
                finishingPoint.Rotate(Vector3.up * -PosNeg3);
                modo++;
                return;
            }

            if (modo == -2)
            {
                finishingPoint.Rotate(Vector3.up * -PosNeg2);
                modo++;
                return;
            }

            if (modo == -1)
            {
                finishingPoint.Rotate(Vector3.up * -PosNeg1);
                modo++;
                return;
            }

            if (modo == 0)
            {
                finishingPoint.Rotate(Vector3.up * -Pos1);
                modo++;
                return;
            }

            if (modo == 1)
            {
                if (qualTotem >=3)
                {
                    finishingPoint.Rotate(Vector3.up * ((PosNeg1 + Pos1) * 1));
                    modo = -1;
                    return;
                }
                finishingPoint.Rotate(Vector3.up * -Pos2);
                modo++;
                return;
            }

            if (modo == 2)
            {
                if (qualTotem >= 2)
                {
                    finishingPoint.Rotate(Vector3.up * ((PosNeg2 + PosNeg1 + Pos1 + Pos2) * 1));
                    modo = -2;
                    return;
                }
                finishingPoint.Rotate(Vector3.up * -Pos3);
                modo++;
                return;
            }

            if (modo == 3)
            {
                finishingPoint.Rotate(Vector3.up * ((PosNeg3 + PosNeg2 + PosNeg1 + Pos1 + Pos2 + Pos3) * 1));
                modo = -3;
                return;
            }
        }



        else if (Input.GetKeyDown(KeyCode.D) /*&& Time.time >= tempoArmazenado*/ && ativaTotem == true)
        {
            tempoArmazenado = Time.time + tempoAdicionado;
            speed = 0.05f;
            
            if(modo == -3)
            {
                finishingPoint.Rotate(Vector3.up * ((PosNeg3 + PosNeg2 + PosNeg1 + Pos1 + Pos2 + Pos3) * -1));
                modo = 3;
                return;
            }

            if (modo == -2)
            {
                if (qualTotem >= 2)
                { 
                    finishingPoint.Rotate(Vector3.up * ((PosNeg2 + PosNeg1 + Pos1 + Pos2) * -1));
                    modo = 2;
                    return;
                }
                finishingPoint.Rotate(Vector3.up * PosNeg3);
                modo--;
                return;

            }
            
            if (modo == -1)
            {
                if (qualTotem >= 3)
                {
                    finishingPoint.Rotate(Vector3.up * ((PosNeg1 + Pos1) * -1));
                    modo = 1;
                    return;
                }
                finishingPoint.Rotate(Vector3.up * PosNeg2);
                modo--;
                return;                
            }

            if (modo == 0)
            {
                finishingPoint.Rotate(Vector3.up * PosNeg1);
                modo--;
                return;                
            }

            if (modo == 1)
            {
                finishingPoint.Rotate(Vector3.up * Pos1);
                modo--;
                return;
            }

            if (modo == 2)
            {
                finishingPoint.Rotate(Vector3.up * Pos2);
                modo--;
                return;
            }

            if (modo == 3)
            {
                finishingPoint.Rotate(Vector3.up * Pos3);
                modo--;
                return;
            }
        }
    }
}