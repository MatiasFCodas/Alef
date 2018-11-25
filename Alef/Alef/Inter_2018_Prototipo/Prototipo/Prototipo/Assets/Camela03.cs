using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camela03 : MonoBehaviour {

    public AudioSource camela03;

    //public Animator animCamelo;

    public GameObject legenda03;

    public CharController parado;

    public bool isComplete;

    public GameObject camelo;




    void Update()
    {
        if (isComplete == true)
        {
            legenda03.SetActive(false);
            //animCamelo.SetTrigger("AndaCamela");

        }

    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NarraCamela02");

    }

    IEnumerator NarraCamela02()
    {
        camela03.Play();
        legenda03.SetActive(true);

        yield return new WaitForSeconds(15);

        isComplete = true;

        StopAllCoroutines();
    }
}
