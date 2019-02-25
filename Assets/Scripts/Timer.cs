using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    public string newGameScene;

    private float timer;
    //private bool canCount = true;
    //private bool doOnce = false;
    void Start()
    {
        timer = mainTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
            //uiText.text = Time.ToString("00");
            uiText.text = string.Format("{0:F2}", timer);
        }

        else if (timer <= 0.0f)
        {
            //canCount = false;
            //doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            SceneManager.LoadScene(newGameScene);

        }
    }
}
