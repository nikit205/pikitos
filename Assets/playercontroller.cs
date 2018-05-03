using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
			
	// Update is called once per frame
	void Update () {
		float V = Input.GetAxis ("Vertical");
		float h = Input.GetAxis ("Horizontal");

		Vector3 dir = new 
			
		
	}
}
