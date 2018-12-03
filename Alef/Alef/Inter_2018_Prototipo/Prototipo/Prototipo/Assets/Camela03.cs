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

    public Animator animMov;
    public Animator animTemplo;
    public AudioSource templo;




    void Update()
    {
        if (isComplete == true)
        {
            legenda03.SetActive(false);
            animMov.SetTrigger("Anda");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (!stop)
        {
            StartCoroutine("NarraCamela03");
            stop = true;
            camelo.GetComponent<BoxCollider>().enabled = false;
        }

    }

    IEnumerator NarraCamela03()
    {
        camela03.Play();
        legenda03.SetActive(true);
        animTemplo.SetTrigger("AtivaTemplo");
        templo.Play();
        animMov.SetTrigger("Levanta");

        yield return new WaitForSeconds(15);


        isComplete = true;

        animCamelo.SetTrigger("AndaCamelaIlha");

        StopAllCoroutines();
    }
}
