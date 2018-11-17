using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour {


    /// <Explicação>
    /// 
    /// Cria o raycast para emitir a "luz" 
    /// e checar as chaves para abrir as 
    /// portas 
    /// 
    /// Talvez fazer a focal light ativar 
    /// por aqui 
    /// (Khalil - 14:40 - 07/11/2018) 
    /// 
    /// </Explicação>


    public GameObject obj;

    public bool chavePortaNormal;
    public bool chavePortaSecreta;



    private void Update()
    {
        DirecaoLuz();
    }


    void DirecaoLuz()
    {
        Vector3 from = obj.transform.position;
        Vector3 direction = obj.transform.TransformDirection(Vector3.down);
        Ray ray = new Ray(obj.transform.position, direction);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 30))
        {


            //Ativa Receptores da Porta Normal
            if (hit.collider.CompareTag("ReceptorNormal"))
            {
                chavePortaNormal = true;
            }
            else
            {
                chavePortaNormal = false;
            }


            //Ativa Receptores da Sala Secreta
            if (hit.collider.CompareTag("ReceptorSecreto"))
            {
                chavePortaSecreta = true;
            }
            else
            {
                chavePortaSecreta = false;
            }

        }
        Debug.DrawRay(from, direction * 30, Color.blue); // Desenha Raycast
    }
}