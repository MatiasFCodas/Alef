using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{

    public GameObject door;
    AudioSource porta;

    // Use this for initialization
    void Start()
    {
        porta = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Face_Botão"))
        {
            porta.Play();
            door.SetActive(false);
        }
    }
}
