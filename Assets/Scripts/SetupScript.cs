using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		GameObject canvas = GameObject.Find("Canvas");
		for (int i=1; i<6; i++) {
			for(int j=1; j<6; j++){
				GameObject newButton = (GameObject)Instantiate(Resources.Load("Grid Space"));
				newButton.transform.SetParent(canvas.transform);
				print(canvas.transform.position);
				newButton.transform.position = new Vector3(418.2f-130f+(i-1)*65f, 208.8f-130f+((6-j)-1)*65f, 0.0f);
				newButton.name = i.ToString()+j.ToString();
			}
		}
		string[,] positionalArray = new string[5,5];
		int level = PlayerPrefs.GetInt("level");
		if(level==1){
			positionalArray[0,0]="Soldier";
			positionalArray[1,1]="Soldier";
			positionalArray[1,0]="Soldier";
			positionalArray[4,4]="Goal";
		}
		else if(level==2){
			positionalArray[0,0]="Soldier";
			positionalArray[1,1]="Soldier";
			positionalArray[1,0]="Soldier";
			positionalArray[2,2]="Town";
			positionalArray[4,4]="Goal";
		
		}
		else{
			positionalArray[0,0]="Soldier";
			positionalArray[1,1]="Soldier";
			positionalArray[1,0]="Soldier";
			positionalArray[4,4]="Goal";
			positionalArray[2,2]="Wall";
		
		}
		for(int i=1;i<6;i++){
			for(int j=1;j<6;j++){
				if(positionalArray[i-1,j-1] != null){
					string itemname = positionalArray[i-1,j-1];
					GameObject newitem = (GameObject)Instantiate(Resources.Load(itemname));
					newitem.tag = itemname;
					newitem.name = itemname+i.ToString()+j.ToString();
					newitem.transform.position = GameObject.Find(i.ToString()+j.ToString()).transform.position;
					MovementSelection.locationArray[(i-1)*5+(j-1)] = itemname;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
