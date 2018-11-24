using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checa_Fase : MonoBehaviour {

    public static int fase02 = 0;

    public static  int fase03Liberado = 0;

    public GameObject camela;

    public bool ok;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Level_02")
        {
            fase03Liberado = 1;
        }
    }

    void Update () {

        if(fase03Liberado == 1)
        {
            ok = true;
            camela.SetActive(true);
        }

        if (fase03Liberado == 0)
        {
            camela.SetActive(false);
        }


	}
}
