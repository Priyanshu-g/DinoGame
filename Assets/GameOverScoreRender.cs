using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreRender : MonoBehaviour
{
    public Text gameOverScreenText;

    // Update is called once per frame
    void Awake()
    {
        gameOverScreenText.text = "Score:" + PlayerPrefs.GetString("PrefScore");
    }
}