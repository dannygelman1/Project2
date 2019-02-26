using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsTwo : MonoBehaviour
{
    public string prevPage;
    //public string main;
    public string playGame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PrevPage()
    {
        SceneManager.LoadScene(prevPage);
    }

    //public void Main()
    //{
    //    SceneManager.LoadScene(main);
    //    Debug.Log("MAIN2");
    //}

    public void Play()
    {
        SceneManager.LoadScene(playGame);
    }
}
