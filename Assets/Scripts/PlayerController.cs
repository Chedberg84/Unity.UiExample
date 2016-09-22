using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    
	public float speed;
	public Text countText;
	public Text gameOver;

	private Rigidbody rb;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		UpdateCountText ();
		gameOver.text = "";
	}
	
	// FixedUpdate is called once per frame before physics calculations run
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count++;
			UpdateCountText ();

			if (count >= 13) {
				gameOver.text = "You have one the game!";
			}
		}
	}

	private void UpdateCountText()
	{
		countText.text = "Count: " + count.ToString ();
	}
}
