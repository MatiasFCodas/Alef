using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaiFase02 : MonoBehaviour {

    public Checa_Chave puzzleMural04;


    private void OnTriggerStay(Collider other)
    {
        if (puzzleMural04.mural04 == true)
        {
            SceneManager.LoadScene("Praça");
        }

    }

}
