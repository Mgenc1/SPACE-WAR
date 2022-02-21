using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public static float Score;

    private float Timer = 150;
    public TextMeshProUGUI TimerText;

   
    void Update()
    {
        Timer -= Time.deltaTime;
        ShowTime();
        ScoreShow();
    }

    private void ScoreShow()
    {
        ScoreText.text = "score" +"  " + Score.ToString();
    }

    private void ShowTime()
    {
        TimerText.text = "TİME" + "  " + Timer.ToString("F0");
    }
}
