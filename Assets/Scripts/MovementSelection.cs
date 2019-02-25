using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class MovementSelection : MonoBehaviour {
	public int currentRow;
	public int currentColumn;
	public static string[] locationArray = Enumerable.Repeat("",25).ToArray();
	public GameObject gameOver;
    public string newGameScene;

	// Use this for initialization
	void Start () {
		string name = gameObject.name;
		int startRow = int.Parse(name.Substring(name.Length-2,1));
		int startColumn = int.Parse(name.Substring(name.Length-1,1));
		currentRow = startRow;
		currentColumn = startColumn;
		locationArray[(currentRow-1)*5+currentColumn-1] = gameObject.name;
		//gameOver = GameObject.Find("GameOver");
		//gameOver.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void MoveSoldier (int[] movement) {
		int SquareRow = SquareSelectionScript.MainSquare[0];
		int SquareColumn = SquareSelectionScript.MainSquare[1];
		if(SquareRow==currentRow+1||SquareRow==currentRow-1||SquareRow==currentRow){
			if(SquareColumn==currentColumn+1||SquareColumn==currentColumn-1||SquareColumn==currentColumn){
				locationArray[(currentRow-1)*5+currentColumn-1] = "";
				currentRow = movement[0]+currentRow;
				currentColumn = movement[1]+currentColumn;
				string squareName = currentRow.ToString()+currentColumn.ToString();
				gameObject.transform.position = GameObject.Find(squareName).transform.position;
				locationArray[(currentRow-1)*5+currentColumn-1] = gameObject.name;
			}
		}
	}
	void resolveTown (int[] newMainSquare) {
		int SquareRow = newMainSquare[0];
		int SquareColumn = newMainSquare[1];
		if(SquareRow==currentRow+1||SquareRow==currentRow-1||SquareRow==currentRow){
			if(SquareColumn==currentColumn+1||SquareColumn==currentColumn-1||SquareColumn==currentColumn){
				GameObject newsoldier = (GameObject)Instantiate(Resources.Load("Soldier"));
				newsoldier.transform.position = gameObject.transform.position;
				newsoldier.tag = "Soldier";
				newsoldier.name = "Soldier"+gameObject.name.Substring(name.Length-2,2);
				locationArray[(currentRow-1)*5+currentColumn-1] = newsoldier.name;
				Destroy(gameObject);
			}
		}
	}
	void resolveGoal (int[] nwMainSquare) {
		int SquareRow = nwMainSquare[0];
		int SquareColumn = nwMainSquare[1];
		//print(nwMainSquare[0]);
		if(SquareRow==currentRow+1||SquareRow==currentRow-1||SquareRow==currentRow){
			if(SquareColumn==currentColumn+1||SquareColumn==currentColumn-1||SquareColumn==currentColumn){
                Debug.Log("you Win!");
                //gameOver = GameObject.Find("GameOver");
				//gameOver.SetActive(true);
                SceneManager.LoadScene(newGameScene);
			}
		}
	
	}
}
