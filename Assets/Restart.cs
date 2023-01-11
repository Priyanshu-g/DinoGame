using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    int seconds = 1;
    bool waitingDone = false;
    public Text restartText;
    bool set = false;
    public int waitingTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds == waitingTime)
        {
            waitingDone = true;
            CancelInvoke("Timer");
        }
        if (waitingDone && !set)
        {
            restartText.text = "Press Any Key To Restart";
            set = true;
        }
        if (Input.anyKey && waitingDone)
        {
            SceneManager.LoadSceneAsync(sceneName: "Game");
            PlayerPrefs.SetString("PrefScore", "0");
        }
    }

    void Timer()
    {
        seconds += 1;
    }
}
