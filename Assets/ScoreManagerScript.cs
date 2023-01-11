using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public Text gameScreenText;
    public Player playerScript;
    public float ScoreSpeed = 0.5f;
    public int startScore;
    public int score = 0;
    string scoreStr;
    // Start is called before the first frame update
    void Start()
    {
        score = startScore;
        InvokeRepeating("ScoreKeeper", 0, ScoreSpeed);
    }

    // Update is called once per frame
    void ScoreKeeper()
    {
        if (playerScript.active)
        {
            score += 1;
        }
        scoreStr = score.ToString();
        PlayerPrefs.SetString("PrefScore", scoreStr);
        gameScreenText.text = "Score:" + PlayerPrefs.GetString("PrefScore");
    }
}
