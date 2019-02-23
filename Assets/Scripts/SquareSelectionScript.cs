using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareSelectionScript : MonoBehaviour {

	static string MainSquare = "None";
	
	// Use this for initialization
	
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		print(MainSquare);
	}

	void TaskOnClick () {
	MainSquare = gameObject.name;
	
    }

}
