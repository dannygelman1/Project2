using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareSelectionScript : MonoBehaviour {

	static List<int> MainSquare;
	
	// Use this for initialization
	
	void Start () {
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void TaskOnClick () {
		int MainSquare1 = int.Parse(gameObject.name.Substring(0,1));
		int MainSquare2 = int.Parse(gameObject.name.Substring(1,1));
		MainSquare = new List<int>();
		MainSquare.Add(MainSquare1);
		MainSquare.Add(MainSquare2);
		print(MainSquare[0]);
    }

}
