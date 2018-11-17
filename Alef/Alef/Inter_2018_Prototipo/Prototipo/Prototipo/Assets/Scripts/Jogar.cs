using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jogar : MonoBehaviour {

    public AudioSource source;



    public void LoadScene(int sceneIndex)
    {
        source.Play();
        SceneManager.LoadScene(sceneIndex);
    }


}
