using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Text counter_text;
	public Text win_text;
	private Rigidbody rb;
	private int counter;


	void Start () {
		rb = GetComponent<Rigidbody> ();
		counter = 0;
		win_text.text = "";
		SetCounter ();
	}


	// Use this for initialization
	void FixedUpdate (){
		float moveHori = Input.GetAxis ("Horizontal");
		float moveVerti = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHori, 0.0f, moveVerti);
		SetCounter ();
		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("pickup")) {
			other.gameObject.SetActive (false);
			counter++;
		}

	}

	void SetCounter(){
		counter_text.text = "Count: " + counter.ToString();
		if (counter >= 15) {
			win_text.text = "You Win!";
		}
	}
}
