using UnityEngine;
using System.Collections;

public class Boulder : MonoBehaviour {

	private GameObject Player;
	private bool isBeingTouched = false;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (isBeingTouched && Input.GetKeyDown (KeyCode.LeftControl)) {
			transform.parent = Player.transform;//collider.GetComponent<MovementControl> ().transform;
		}
	}

	void OnTriggerStay2D(Collider2D collider){
		if (collider.gameObject == Player) {
			isBeingTouched = true;
			print ("you can pick me baby");
		}
	}
	void OnTriggerExit2D(Collider2D collider){
		if (collider.gameObject == Player) {
			isBeingTouched = false;
			print ("you can pick me baby");
		}
	}
}
