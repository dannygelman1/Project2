﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareSelectionScript : MonoBehaviour {

	static public List<int> MainSquare = new List<int>();
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
		}
		else if(MovementSelection.locationArray[(MainSquare1-1)*5+MainSquare2-1].Contains("Soldier")){
			int[] movement = new int[2];
			movement[0] = MainSquare1 - MainSquare[0];
			movement[1] = MainSquare2 - MainSquare[1];
			int[] newMainSquare = new int[2];
			newMainSquare[0] = MainSquare1;
			newMainSquare[1] = MainSquare2;
			GameObject[] soldiers = GameObject.FindGameObjectsWithTag("Soldier");
			GameObject[] towns = GameObject.FindGameObjectsWithTag("Town");
			GameObject[] goals = GameObject.FindGameObjectsWithTag("Goal");
			foreach (GameObject soldier in soldiers)
			{
				print(soldier.name);
				soldier.SendMessage("MoveSoldier", movement);
			}
			foreach (GameObject town in towns)
			{
				town.SendMessage("resolveTown", newMainSquare);
			}
			foreach (GameObject goal in goals)
			{
				goal.SendMessage("resolveGoal", newMainSquare);
			}
			GameObject.Find(MainSquare[0].ToString()+MainSquare[1].ToString()).GetComponent<Image>().color = Color.red;
			MainSquare = new List<int>();
		}
		else {
			GameObject.Find(MainSquare[0].ToString()+MainSquare[1].ToString()).GetComponent<Image>().color = Color.red;
			MainSquare = new List<int>();	
		}
    }

}
