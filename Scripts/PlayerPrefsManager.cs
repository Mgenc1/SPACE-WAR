using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{

    public  Button[] LevelAll;

    public static PlayerPrefsManager instance;
    private static PlayerPrefsManager Instance
    {
        get
        {
            if (instance == null)
               instance = FindObjectOfType<PlayerPrefsManager>();

            return instance;
        }

    }

    private void OnEnable()
    {
        SetStateOfAllLevelButtons();
    }


    public void SetScore(float score)
    {
        PlayerPrefs.SetFloat("Score", score);
    }

    public float GetScore()
    {
        return PlayerPrefs.GetFloat("Score");
    }

    public void SetStateOfAllLevelButtons()
    {
        foreach (Button b in LevelAll)
        {
            b.interactable = PlayerPrefs.GetString(b.name) == "True";

        }

    }

}
