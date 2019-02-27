using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public static int level = 1;
	// Use this for initialization
	void Start () {
	PlayerPrefs.SetInt("level",1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
