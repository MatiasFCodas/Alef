using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    public GameObject player;
    public bool inPuzzle = false;
    public bool isWalking = false;

	public GameObject cam;
	public GameObject mark;
	public GameObject shot;

	private CharacterController controller;
	private float AngularSpeed = 100;
	private float walkSpeed = 6;
	private float gravity = 0.5f;
    public float jumpSpeed = 5;
	private float mouseSensivity = 30; 
	private float rotationX = 0;
	private Vector3 moveDirection = Vector3.zero;

    public AudioSource steps;
    public AudioSource jump;

	void Start () {
		controller = GetComponent<CharacterController>();
        steps = GetComponent<AudioSource>();
        jump = GetComponent<AudioSource>();
	}



   /* void ObjGrab()
    {
        Vector3 from = cam.transform.position;
        Vector3 direction = cam.transform.TransformDirection(Vector3.forward);
        Ray ray = new Ray(cam.transform.position, direction);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5))
        {
            if (hit.collider.CompareTag("crate"))
            {
                GameObject hitObj = hit.collider.gameObject;
                hitObj.GetComponent<Renderer>().material.color = Color.red;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hitObj.transform.SetParent(cam.transform);
                    hitObj.GetComponent<Rigidbody>().isKinematic = true;
                }

                if (Input.GetKeyUp(KeyCode.E))
                {
                    hitObj.transform.SetParent(null);
                    hitObj.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
        Debug.DrawRay(from, direction * 5, Color.blue);
    }*/


    void FixedUpdate () {

        if (moveDirection.x > 0 && steps.isPlaying == false )
        {
           steps.Play();
        }

        if (moveDirection.x < 0 && steps.isPlaying == false)
        {
            steps.Play();
        }

        if (moveDirection.x == 0 && moveDirection.z == 0 )
        {
            steps.Stop();
        }


        if(inPuzzle ==true)
        {
            player.SetActive(false);
        }
        else
        {
            player.SetActive(true);
        }




       // ObjGrab();
		RotateView();

		if(controller.isGrounded){

			moveDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
            {
                moveDirection.x = -walkSpeed;
            }
            if (Input.GetKey(KeyCode.D)) {
                moveDirection.x = walkSpeed;

            }
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection.z = walkSpeed;

            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection.z = -walkSpeed;

            }



            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
                jump.Play(0);
            }

		}

		moveDirection.y -= gravity;

		controller.Move(moveDirection * Time.deltaTime);
	}

	
		
	void RotateView(){
		//rotaciona a câmera na horizontal
		transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime);

		//rotaciona a câmera na vertical
		rotationX += Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime * -1;
		rotationX = Mathf.Clamp(rotationX, -45,45);

		cam.transform.localEulerAngles = new Vector3(-rotationX, 
		                                             cam.transform.localEulerAngles.y,
		                                             cam.transform.localEulerAngles.z);                                        
	}
}
