using System.Collections;
//using System.Object;
//using System.Single;
//using System.Boolean;
using System.Collections.Generic;
using UnityEngine;

public class village : MonoBehaviour
{
    // Start is called before the first frame update

    public string caught = "not";
    public float positionX;
    public float positionY;
    public float distanceX;
    public float distanceY;
    //static Tuple<int> MainSquare;
   // public float  = this.transform.position.y;
    // Update is called once per frame

    void Start()
    {
        positionX = gameObject.transform.position.x;
        positionY = gameObject.transform.position.y;
        distanceX = positionX - MainSquare.Item1;
        distanceY = positionY - MainSquare.Item1;

    }  

    void Update()
    {
        if (distanceX <= 0.128 || distanceY <= 0.128)
        {
            caught = "caught";
        }

        if (caught == "caught")
        {
            Instantiate(Piece, this.transform.position);
            Destroy(this);
        }


    }
}
