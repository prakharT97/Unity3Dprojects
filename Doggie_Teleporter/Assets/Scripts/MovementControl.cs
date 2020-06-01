using UnityEngine;
using System.Collections;

public class MovementControl : MonoBehaviour {
     
	[SerializeField] private float jumpSpeed = 1, walkSpeed = 1,speedCap = 1;

	private Rigidbody2D rb;
	private Vector2 MousePos;
    public bool isGrounded;
    public int dir;
	private nonTeleport nonTelep;
	private GameObject g;


	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		GameObject g = GameObject.Find("nonTeleportZone");
		nonTelep = g.GetComponent<nonTeleport>();

	}
	
	// Update is called once per frame
	void Update () {
		




		MousePos = Input.mousePosition;
        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
            dir = 1;
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            dir = -1;
        }

        if (Input.GetKeyDown (KeyCode.Space)&&isGrounded) {
			rb.AddForce (Vector2.up*jumpSpeed);
		}

		if (Input.GetKey (KeyCode.D)) {
			//transform.Translate (Vector2.right*Time.deltaTime*walkSpeed);
			if(rb.velocity.magnitude < speedCap)
			rb.AddForce (Vector2.right*walkSpeed*Mathf.Abs((walkSpeed - rb.velocity.magnitude)));
		}
		if (Input.GetKey (KeyCode.A)) {
			//transform.Translate (Vector2.left*Time.deltaTime*walkSpeed);
			if(rb.velocity.magnitude < speedCap)
			rb.AddForce (Vector2.left*walkSpeed*Mathf.Abs((walkSpeed - rb.velocity.magnitude)));
		}



		if (Input.GetMouseButtonDown (0)&&nonTelep.nonTele==false) {
			
			transform.position = (Vector3)Camera.main.ScreenToWorldPoint (new Vector2 (MousePos.x, MousePos.y)) + new Vector3(0,0,10);
            
		}

	}
}
