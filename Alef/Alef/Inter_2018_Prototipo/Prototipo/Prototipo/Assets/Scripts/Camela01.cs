using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camela01 : MonoBehaviour {

    public AudioSource camela;
    public GameObject legenda;
    public CharController parado;
    public bool isComplete;



    private void Update()
    {
        if (isComplete == true)
        {
            legenda.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NarraCamela");
        
    }

    IEnumerator NarraCamela()
    {
        camela.Play();
        legenda.SetActive(true);

        yield return new WaitForSeconds(25);

        isComplete = true;

        StopAllCoroutines();
    }


}
