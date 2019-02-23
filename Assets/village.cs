using System.Collections;
//using System.Object;
//using System.Single;
//using System.Boolean;
using System.Collections.Generic;
using UnityEngine;
using System;

public class village : MonoBehaviour
{
    // Start is called before the first frame update

    private string caught = "not";
    public Transform p;
    private float positionX;
    private float positionY;
    private float distanceX;
    private float distanceY;
    //static List<int> SquareSelctionScript.MainSquare;
   // public float  = this.transform.position.y;
    // Update is called once per frame

    void Start()
    {

        //Instantiate(Piece, transform.position, transform.rotation);
        positionX = gameObject.transform.position.x;
        positionY = gameObject.transform.position.y;
        distanceX = positionX;
        distanceY = positionY;
        if (SquareSelectionScript.MainSquare.Count != 0){
            distanceX = Math.Abs(positionX - SquareSelectionScript.MainSquare[0]);
            distanceY = Math.Abs(positionY - SquareSelectionScript.MainSquare[1]);
        }

       

    }  

    void Update()
    {   
        print(positionX);
        print(positionY);
        if (distanceX <= 0.128 || distanceY <= 0.128)
        {
            caught = "caught";
           // print("caught!!!");
        }

        if (caught == "caught")
        {
            Instantiate(p, new Vector3(positionX, positionY, 0), Quaternion.identity);
            Destroy(this);
        }


    }
}
