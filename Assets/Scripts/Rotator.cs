using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	private Vector3 rotatevec = new Vector3 (15, 30, 45);
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotatevec*Time.deltaTime);
	
	}
}
