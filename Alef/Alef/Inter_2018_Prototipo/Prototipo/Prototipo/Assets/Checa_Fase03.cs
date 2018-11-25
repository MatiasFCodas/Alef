using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checa_Fase03 : MonoBehaviour {

    public static int ilhaLiberado = 0;

    public GameObject camela02;

    public bool ok2;

    // Use this for initialization
    void Start () {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Level_03")
        {
            ilhaLiberado = 1;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if(ilhaLiberado == 1)
        {
            ok2 = true;
            camela02.SetActive(true);
        }

       else if (ilhaLiberado == 0)
        {
            camela02.SetActive(false);
        }
    }
}
