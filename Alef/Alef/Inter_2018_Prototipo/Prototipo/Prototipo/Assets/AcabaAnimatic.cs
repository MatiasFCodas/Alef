using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AcabaAnimatic : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) ComecaTutorial();
    }

    void ComecaTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
