using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{

    public float speed = 1;

    void Update()
    {

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.right * Input.GetAxisRaw("Horizontal") * speed;

        }
        else if (Input.GetAxisRaw("Vertical") != 0)
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.forward * -Input.GetAxisRaw("Vertical") * speed;

        }
    }

}