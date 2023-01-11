using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCon : MonoBehaviour
{
    public GameObject sce1;
    public GameObject sce2;
    public GameObject sce3;
    public GameObject dino;
    public SpriteRenderer back1;
    public SpriteRenderer back2;
    public SpriteRenderer back3;
    int curLoop = 1;
    int curTar = 1;
    int setLevel = 1;
    int wantedLevel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        wantedLevel = PlayerPrefs.GetInt("Level");
        if (dino.transform.position.x >= curLoop * 18)
        {
            if (curTar == 1)
            {
                curLoop += 1;
                curTar = 2;
                sce1.transform.Translate(54, 0, 0);
            }
            else if (curTar == 2)
            {
                curLoop += 1;
                curTar = 3;
                sce2.transform.Translate(54, 0, 0);
            }
            else if (curTar == 3)
            {
                curLoop += 1;
                curTar = 1;
                sce3.transform.Translate(54, 0, 0);
            }
        }
        if (setLevel != wantedLevel)
        {
            if (wantedLevel == 2)
            {
                back1.color = new Color(0.8f, 0.82f, 1, 1);
                back2.color = new Color(0.8f, 0.82f, 1, 1);
                back3.color = new Color(0.8f, 0.82f, 1, 1);
                setLevel = 2;
            }
            else if (wantedLevel == 3)
            {
                back1.color = new Color(0.6f, 1, 0.77f, 1);
                back2.color = new Color(0.6f, 1, 0.77f, 1);
                back3.color = new Color(0.6f, 1, 0.77f, 1);
                setLevel = 3;
            }
            else if (wantedLevel == 4)
            {
                back1.color = new Color(0.8f, 0.82f, 1, 1);
                back2.color = new Color(0.8f, 0.82f, 1, 1);
                back3.color = new Color(0.8f, 0.82f, 1, 1);
                setLevel = 4;
            }
            else if (wantedLevel == 5)
            {
                back1.color = new Color(0.8f, 0.82f, 1, 1);
                back2.color = new Color(0.8f, 0.82f, 1, 1);
                back3.color = new Color(0.8f, 0.82f, 1, 1);
                setLevel = 5;
            }
            else if (wantedLevel == 6)
            {
                back1.color = new Color(0.8f, 0.82f, 1, 1);
                back2.color = new Color(0.8f, 0.82f, 1, 1);
                back3.color = new Color(0.8f, 0.82f, 1, 1);
                setLevel = 6;
            }
            else if (wantedLevel == 7)
            {
                back1.color = new Color(0.8f, 0.82f, 1, 1);
                back2.color = new Color(0.8f, 0.82f, 1, 1);
                back3.color = new Color(0.8f, 0.82f, 1, 1);
                setLevel = 7;
            }
        }
    }
}
