using UnityEngine;
using System.Collections;

public class CameraController1stPerson : MonoBehaviour {

	public GameObject player;

	public int movementSpeed;

	//private Vector3 offset;

	// Use this for initialization
	void Start () {
		//offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	// LateUpdate is called after all objects have been processed for a given frame.
	void LateUpdate () {
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime); 
		}

		if(Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3. right *   movementSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime); 
		}

		if(Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back *   movementSpeed * Time.deltaTime);
		}

	}
}
