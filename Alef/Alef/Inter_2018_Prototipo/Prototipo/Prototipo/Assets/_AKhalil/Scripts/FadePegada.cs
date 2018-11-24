using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePegada : MonoBehaviour {

    /// <Explicacao>
    /// 
    /// Para habilitar o efeito de fade em 
    /// algum game object basta adicionar este
    /// script em um game object, adicionar um 
    /// componente "Animator", desativar o 
    ///  animator e associar o "PegadaAnimator" 
    ///  a ele
    /// 
    /// Feito isso decida o tempo em que 
    /// a animacao irá comecar a rodar
    /// alterando o número "StartTimer"
    /// que pode ser encontrado no 
    /// "Inspector" do objeto em que o 
    /// código foi associado
    /// 
    /// </Explicacao>

    public Animator anim;

    public MeshRenderer mesh;

    public float StartTimer;

    private void Start()
    {
        anim = GetComponent<Animator>();
        mesh = GetComponent<MeshRenderer>();
    }


    private void Update()
    {
        if (Time.time >= StartTimer) {
            anim.enabled = true;
        }
        if (Time.time >= StartTimer + 1.9f)
        {
            mesh.enabled = false;
        }
    }





}
