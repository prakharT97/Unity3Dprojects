using UnityEngine;
using System.Collections;

public class isCarry : MonoBehaviour {

    public float carryRange;
    GameObject boulder;
    public bool isCarried;
    Rigidbody2D rb2dboulder;
    Rigidbody2D rb2d;
    GameObject hand;
    private MovementControl movectrl;


    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        hand = GameObject.FindGameObjectWithTag("hand");
        boulder = GameObject.FindGameObjectWithTag("boulder");
        rb2dboulder = boulder.GetComponent<Rigidbody2D>();
        movectrl = gameObject.GetComponentInParent<MovementControl>();
    }
	
	
	void Update () {
        if (Input.GetButtonDown("Carry"))
        {

            if (Mathf.Abs(boulder.transform.position.x) - Mathf.Abs(transform.position.x) < carryRange)
            {

                isCarried = true;
                boulder.transform.parent = hand.transform;
                rb2dboulder.mass = 0;
                rb2dboulder.freezeRotation = true;

            }

        }
			

        if (isCarried)
        {
            boulder.transform.position = hand.transform.position;
        }    

            if (Input.GetButtonDown("Drop") && isCarried == true)
            {

                
                isCarried = false;
                rb2dboulder.mass = 1;
                boulder.transform.parent = null;

                rb2dboulder.velocity = new Vector2(-movectrl.dir*(Mathf.Abs(rb2d.velocity.x)+3),rb2d.velocity.y);
                rb2d.velocity = new Vector2(-movectrl.dir*(Mathf.Abs(rb2d.velocity.x)-Mathf.Abs(rb2dboulder.velocity.x)),(Mathf.Abs(rb2d.velocity.y)-Mathf.Abs(rb2dboulder.velocity.y)));
            
        }

            

    }
}
