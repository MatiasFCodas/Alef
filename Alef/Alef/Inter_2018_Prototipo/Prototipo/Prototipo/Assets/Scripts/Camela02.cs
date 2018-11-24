using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camela02 : MonoBehaviour
{

    public AudioSource camela02;

    public Animator animCamelo;

    public GameObject legenda02;

    public CharController parado;

    public bool isComplete;

    public GameObject camelo;




     void Update()
    {
        if (isComplete == true)
        {
            legenda02.SetActive(false);
            animCamelo.SetTrigger("AndaCamela");

        }

    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("NarraCamela02");

    }

    IEnumerator NarraCamela02()
    {
        camela02.Play();
        legenda02.SetActive(true);

        yield return new WaitForSeconds(15);

        isComplete = true;

        StopAllCoroutines();
    }
}

