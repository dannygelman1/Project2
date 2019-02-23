using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	                if (Input.GetKey("up"))
        {
                    transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                print("up arrow key is held down");
        }
 
        if (Input.GetKey("down"))
        {
                        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            print("down arrow key is held down");
        }  			
	}
}
