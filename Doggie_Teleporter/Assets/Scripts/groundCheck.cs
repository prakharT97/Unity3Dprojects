using UnityEngine;
using System.Collections;

public class groundCheck : MonoBehaviour {


    private MovementControl movectrl;

	void Start () {

        movectrl = gameObject.GetComponentInParent<MovementControl>();
    }
	
	void OnTriggerEnter2D(Collider2D col)
    {
        
            movectrl.isGrounded = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
       
            movectrl.isGrounded = false;
    }
}
