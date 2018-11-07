using UnityEngine;
using System.Collections;

public class ControlShot : MonoBehaviour {

	private float force = 1000;
	private Rigidbody rb;

	void Start () {
		//Quando o tiro é instanciado, é adicionada uma grande impulso para ele ir para frente
		rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce(Vector3.forward * force);

		//tiro é destruído após 3s
		Destroy(gameObject, 3);
	}

}
