using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) SceneManager.LoadScene("Menu");
    }

    void FimAnimatic()
    {
        SceneManager.LoadScene("Menu");
    }
}
