﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {


    public float speed;
	private Rigidbody rb;
    

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

    // Update is called once per frame
    void Update() { 

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(h, 0, v);
        rb.AddForce(dir * speed);
    }




    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
