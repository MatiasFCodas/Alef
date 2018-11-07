using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        Vector3 pos = transform.TransformDirection(Vector3.down);
        Ray ray = new Ray(transform.position, pos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2))
        {
            rb.AddForce(Vector3.up * 100);
            GetComponent<Renderer>().material.color = Color.red;
        }
        else {
            GetComponent<Renderer>().material.color = Color.white;
        }

        Debug.DrawRay(transform.position, pos* 2, Color.red);
	}
}
