using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonTeleport : MonoBehaviour {

	public bool nonTele;

	void Start () {

		nonTele = false;
	}


	void OnMouseEnter(){
	
		nonTele = true;
	
	}

	void OnMouseExit(){
	
	
		nonTele = false;

	}

}
