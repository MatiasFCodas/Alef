using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    /// <Explicação>
    /// 
    /// 
    /// 
    /// </Explicação>

    int seleção = 1;
    
	void Move_Menu () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (seleção >= 3)
            {
                seleção = 1;
            }
            seleção++;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (seleção <= 1)
            {
                seleção = 3;
            }
            seleção--;
        }
	}
}
