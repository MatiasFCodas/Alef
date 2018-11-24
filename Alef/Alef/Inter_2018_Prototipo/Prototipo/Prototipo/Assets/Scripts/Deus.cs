using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class Deus : MonoBehaviour {

    public AudioSource falaDeus;
    public CinemachineFreeLook camDeus;
    public Transform targetDeus;
    public GameObject hitBoxNarracao;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Final");
    }

    IEnumerator Final()
    {
        falaDeus.Play();
        camDeus.Priority = 12;
        camDeus.LookAt = targetDeus;
        hitBoxNarracao.GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(50);
        SceneManager.LoadScene("Final");



    }
}
