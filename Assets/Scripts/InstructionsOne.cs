using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsOne : MonoBehaviour
{
    public string nextPage;
    public string mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextPage()
    {
        SceneManager.LoadScene(nextPage);
        Debug.Log("NEXT");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
        Debug.Log("MAIN1");
    }
}
