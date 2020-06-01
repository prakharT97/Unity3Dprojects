using UnityEngine;
using System.Collections;

public class WrapAround : MonoBehaviour {

    /// <summary>
    /// Wraps the Object to which it is added to wrap around the screen
    /// </summary>

   
    
    private Vector2 ObjectPosition;
 //   private float ScreenWidth, ScreenHeight;

	// Use this for initialization
	void Start () {
	
	}

   

	// Update is called once per frame
	void Update () {
        ObjectPosition = Camera.main.WorldToViewportPoint(transform.position);
        if(ObjectPosition.x > 1)
        {
            print("Off to the right");
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(-1, ObjectPosition.y, 0)) + new Vector3(0,0,5);
        }
        else if (ObjectPosition.x < 0)
        {
            print("Off to the left");
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1, ObjectPosition.y, 0)) + new Vector3(0,0,5);
        }

        if (ObjectPosition.y > 1)
        {
            print("Off to the top");
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3(ObjectPosition.x,0, 0)) + new Vector3(0, 0, 10);
        }
        else if (ObjectPosition.y < 0)
        {
            print("Off to the bottom");
            transform.position = Camera.main.ViewportToWorldPoint(new Vector3( ObjectPosition.x,1, 0)) + new Vector3(0, 0, 10);
        }

    }
}
