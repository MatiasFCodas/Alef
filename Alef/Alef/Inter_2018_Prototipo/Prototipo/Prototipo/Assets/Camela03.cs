using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camela03 : MonoBehaviour {

    public AudioSource camela03;

    public Animator animCamelo;

    public GameObject legenda03;

    public CharController parado;

    public bool isComplete;
    public bool stop;

    public GameObject camelo;




    void Update()
    {
        if (isComplete == true)
        {
            legenda03.SetActive(false);


        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (!stop)
        {
            StartCoroutine("NarraCamela03");
            stop = true;
        }

    }

    IEnumerator NarraCamela03()
    {
        camela03.Play();
        legenda03.SetActive(true);

        yield return new WaitForSeconds(15);


        isComplete = true;

        animCamelo.SetTrigger("AndaCamelaIlha");

        StopAllCoroutines();
    }
}
