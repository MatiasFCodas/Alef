using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checa_Fase : MonoBehaviour {

    public static int fase02 = 0;

    public static int fase01Liberado = 0;

    public static int fase02Liberado = 0;

    public static  int fase03Liberado = 0;

    public static int ilhaLiberado = 0;

    public GameObject camela;

    public GameObject camela02;

    public bool ok;
    public bool ok2;
    public bool ok3;
    public bool ok4;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == "Tutorial")
        {
            fase01Liberado = 1;
        }

       else if(sceneName == "Level_01")
        {
            fase02Liberado = 1;
        }

       else if (sceneName == "Level_02")
        {
            fase03Liberado = 1;
        }

      else if  (sceneName == "Level_03")
        {
            ilhaLiberado = 1;
        }
    }

    void Update () {

        if(fase01Liberado == 1)
        {
            ok = true;
        }

        if(fase02Liberado == 1)
        {
            ok2 = true;
        }

        if(fase03Liberado == 1)
        {
            ok3 = true;
            camela.SetActive(true);
        }


        if(ilhaLiberado == 1)
        {
            ok4 = true;
            camela.SetActive(false);
            camela02.SetActive(true);
        }



	}
}
