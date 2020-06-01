using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanForce : MonoBehaviour {

	public bool inFang1;
	public bool inFang2;
	private GameObject g1;
	private GameObject g2;
	private Rigidbody2D r1;
	private Rigidbody2D r2;

	void Start(){

		g1 = GameObject.Find ("Player");
		r1 = g1.GetComponent<Rigidbody2D> ();
		g2 = GameObject.Find ("boulder");
		r2 = g2.GetComponent<Rigidbody2D> ();


	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject == g1) {
		
			inFang1 = true;

		}

		if (col.gameObject == g2) {
		
			inFang2 = true;

		}
	}

	void OnTriggerStay2D(Collider2D col){
	
		if (col.gameObject == g1) {

			inFang1 = true;

		}

		if (col.gameObject == g2) {

			inFang2 = true;

		}
	
	}

	void OnTriggerExit2D(Collider2D col){

		if (col.gameObject == g1) {

			inFang1 = false;

		}

		if (col.gameObject == g2) {

			inFang2 = false;

		}
	
	}


	void Update(){

		if (inFang1 == true) {
		
			r1.AddForce (Vector2.up*20);

		}

		if (inFang2 == true) {
		
			r2.AddForce (Vector2.up*20);
		
		}

	

	}




}
