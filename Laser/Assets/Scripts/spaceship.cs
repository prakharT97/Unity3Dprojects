using UnityEngine;
using System.Collections;

public class spaceship : MonoBehaviour {

    public GameObject bullet;
    public GameObject bog;
    Rigidbody2D rb;
    AudioSource a;
    
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        a = GetComponent<AudioSource>();

    }
	
	void Update () {


        if (Input.GetKey(KeyCode.RightArrow)){

            transform.eulerAngles += new Vector3(0, 0,-1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.eulerAngles += new Vector3(0, 0, 1);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject inst = Instantiate(bullet,bog.transform.position + new Vector3(0,0,-5),bog.transform.rotation) as GameObject;
            Rigidbody2D bulletrb = inst.GetComponent<Rigidbody2D>();
            bulletrb.AddForce(bog.transform.up*100);
            a.Play();
        }
    }
}
