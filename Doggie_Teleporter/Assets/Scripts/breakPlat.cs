using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakPlat : MonoBehaviour {

	private GameObject g3;
	private Rigidbody2D r;
	void Start () 
	{

		g3 = GameObject.Find ("Player");
		r = g3.GetComponent<Rigidbody2D>();

	}
	
	void OnTriggerEnter2D(Collider2D col){


		if (r.velocity.magnitude > 20) {

			Destroy (transform.parent.gameObject);
		}

	
	}

}
