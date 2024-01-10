using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Ui_TextCtrl : MonoBehaviour
{
    public static Ui_TextCtrl uiText;
    public Text timeText;
    public Text scoreText;
    public static int score = 0;
    float ss,mm;
    void Start()
    {
        uiText = this;
    }

    // Update is called once per frame
    void Update()
    {
        ss += Time.deltaTime;
        int tempTime = (int)ss;
        if (tempTime > 60)
        {
            ss = 0;
            mm ++;
        }
        timeText.text = string.Format($"{mm} : {ss}");
    }
    public int GetScore()
    { 
        return score;
    }
    public void SetScore(int nPoint)
    {
        score += nPoint;
        scoreText.text = score.ToString("0000");
    }

}
