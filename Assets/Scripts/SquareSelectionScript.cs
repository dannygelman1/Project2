using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareSelectionScript : MonoBehaviour {

	static List<int> MainSquare = new List<int>();
	
	// Use this for initialization
	
	void Start () {

		GetComponent<Image>().color = Color.red;
		Button btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void TaskOnClick () {

		int MainSquare1 = int.Parse(gameObject.name.Substring(0,1));
		int MainSquare2 = int.Parse(gameObject.name.Substring(1,1));
		if (MainSquare.Count==0){
			MainSquare = new List<int>();
			MainSquare.Add(MainSquare1);
			MainSquare.Add(MainSquare2);
			GetComponent<Image>().color = Color.blue;
			//print(MainSquare[0]);
		}
		else if (MainSquare[0]==MainSquare1 && MainSquare[1]==MainSquare2) {
			MainSquare = new List<int>();
			GetComponent<Image>().color = Color.red;
		}
    }

}
