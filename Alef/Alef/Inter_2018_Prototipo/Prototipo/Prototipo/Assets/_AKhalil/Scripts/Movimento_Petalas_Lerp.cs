﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Petalas_Lerp : MonoBehaviour {


    /// <Explicação>
    /// 
    /// 
    /// 
    /// </Explicação>


    // Pontos de referência para a movimentação das petalas
    Transform startingPoint;
    Transform finishingPoint;


    // Velocidade de movimento da petala até a referência (Lerp)
    public float speed;


    // Referencias das petalas que irão girar
    // Caso haja a necessidade de refazer as associações apagar "[HideInInspector]"
    /*[HideInInspector]*/ public Transform Alterado_01;
    /*[HideInInspector]*/ public Transform Alterado_02;
    /*[HideInInspector]*/ public Transform Alterado_03;
    [HideInInspector] public Transform Referencia_01;
    [HideInInspector] public Transform Referencia_02;
    [HideInInspector] public Transform Referencia_03;



    public Totem_Manager totem;


    // Quanto no puzzle o jogador avançou / Quantas partes da flor ele liberou
    public int estagio; 


    // Variável que auxilia o calculo de movimentos, dizendo quantos graus cada pétala se move por vez
    public float distancia;


    // Diz qual a posição das possibilidades o totem está, auxiliando o algoritmo a saber qual movimento deve ser
    // feito a seguir
    public float posicao; 


    // Variável que auxilia o cálculo de movimentos a limitar o número de movimentos da pétala
    public int ajuste;

    // Diz qual das pétalas está selecionada no momento
    [HideInInspector]public float petalaSelecionada = 1;


    // Armazena a posição atual da petala selecionada, impedindo que o número de movimentos realizado por uma peça
    // influencíe nas outras
    float posicaoArmazenada_01;
    float posicaoArmazenada_02;
    float posicaoArmazenada_03;


    public float tempoArmazenado;
    public float tempoAdicionado = 1.5f;


    void Start()
    {
        posicao = 0;
    }



    void FixedUpdate()
    {
        MudaPetala();
        totem.totemSelecionado = petalaSelecionada;
        petalaSelecionada = totem.totemSelecionado;
    }






    void MudaPetala()
    {
        if (petalaSelecionada == 1)
        {
            distancia = 30;
            ajuste = 0;
            posicao = posicaoArmazenada_01;
            startingPoint = Alterado_01;
            finishingPoint = Referencia_01;
            GiraPetala();
            posicaoArmazenada_01 = posicao;
        }
        else if (petalaSelecionada == 2)
        {
            distancia = 45;
            ajuste = 1;
            posicao = posicaoArmazenada_02;
            startingPoint = Alterado_02;
            finishingPoint = Referencia_02;
            GiraPetala();
            posicaoArmazenada_02 = posicao;
        }
        else if (petalaSelecionada == 3)
        {
            distancia = 60;
            ajuste = 2;
            posicao = posicaoArmazenada_03;
            startingPoint = Alterado_03;
            finishingPoint = Referencia_03;
            GiraPetala();
            posicaoArmazenada_03 = posicao;
        }

        if (estagio == 2) // Alteração entre as petalas caso o jogador esteja no nivel 2
        {
            if (Input.GetKeyDown(KeyCode.W) && Time.time >= totem.tempoArmazenado && Time.time >= tempoArmazenado) //===== CIMA =====//
            {
                totem.tempoArmazenado = Time.time + totem.tempoAdicionado;
                if (petalaSelecionada >= 2) petalaSelecionada--;
                else petalaSelecionada = 2;
            }

            if (Input.GetKeyDown(KeyCode.S) && Time.time >= totem.tempoArmazenado && Time.time >= tempoArmazenado) //===== BAIXO =====//
            {
                totem.tempoArmazenado = Time.time + totem.tempoAdicionado;
                if (petalaSelecionada <= 1) petalaSelecionada++;
                else petalaSelecionada = 1;
            }
        } // Alteração entre as petalas caso o jogador esteja no nivel 2

        if (estagio == 3)// Alteração entre as petalas caso o jogador esteja no nivel 3
        {
            if (Input.GetKeyDown(KeyCode.W) && Time.time >= totem.tempoArmazenado && Time.time >= tempoArmazenado) //===== CIMA =====//
            {
                totem.tempoArmazenado = Time.time + totem.tempoAdicionado;
                if (petalaSelecionada >= 2) petalaSelecionada--;
                else petalaSelecionada = 3;
            }

            if (Input.GetKeyDown(KeyCode.S) && Time.time >= totem.tempoArmazenado && Time.time >= tempoArmazenado) //===== BAIXO =====//
            {
                totem.tempoArmazenado = Time.time + totem.tempoAdicionado;
                if (petalaSelecionada <= 2) petalaSelecionada++;
                else petalaSelecionada = 1;
            }
        }// Alteração entre as petalas caso o jogador esteja no nivel 3

    }



    void GiraPetala()
    {

        Quaternion newFinishingPoint = finishingPoint.rotation;
        Quaternion smootheredThing = Quaternion.Lerp(startingPoint.rotation, newFinishingPoint, speed);
        startingPoint.rotation = smootheredThing;



        if (Input.GetKeyDown(KeyCode.D) && Time.time >= tempoArmazenado)
        {
            tempoArmazenado = Time.time + tempoAdicionado;
            totem.speed = 1;
            if (posicao > -distancia * (estagio - ajuste))
            {
                finishingPoint.Rotate(Vector3.up * -distancia); // Subtrair variavel de estados
                posicao -= distancia;
            }
            else
            {
                finishingPoint.Rotate(Vector3.up * distancia * ((estagio - ajuste) * 2)); // Subtrair variavel de estados
                posicao = distancia * (estagio - ajuste);
            }
        }



        else if (Input.GetKeyDown(KeyCode.A) && Time.time >= tempoArmazenado)
        {
            tempoArmazenado = Time.time + tempoAdicionado;
            totem.speed = 1;
            if (posicao < distancia * (estagio - ajuste))
            {
                finishingPoint.Rotate(Vector3.up * distancia); // Subtrair variavel de estados
                posicao += distancia;
            }
            else
            {
                finishingPoint.Rotate(Vector3.up * -distancia * ((estagio - ajuste) * 2)); // Subtrair variavel de estados
                posicao = -distancia * (estagio - ajuste);
            }
        }
    }
}