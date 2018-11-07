using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    public GameObject obj;


    void DirecaoLuz()
    {
        Vector3 from = obj.transform.position;
        Vector3 direction = obj.transform.TransformDirection(Vector3.down);
        Ray ray = new Ray(obj.transform.position, direction);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 30))
        {
            if (hit.collider.CompareTag("Receptor"))
            {
                GameObject hitObj = hit.collider.gameObject;
                hitObj.GetComponent<Renderer>().material.color = Color.red;

            }
                   
        }
        Debug.DrawRay(from, direction * 30, Color.blue);
    }

    private void Update()
    {
        DirecaoLuz();
    }
}