using UnityEngine;
using System.Collections;

public class PlayerController1stPerson : MonoBehaviour {

	public float movementSpeed;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// FixedUpdate is called once per frame before physics calculations run
	void FixedUpdate () {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");

		//Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		//rb.AddForce (movement * speed);

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

	void OnTriggerEnter(Collider other) 
	{
		//if (other.gameObject.CompareTag ("PickUp")) 
		//{
		//	other.gameObject.SetActive (false);
		//}
	}
}