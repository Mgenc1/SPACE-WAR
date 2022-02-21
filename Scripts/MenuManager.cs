using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    [Header("PANELS")]
    public GameObject PlayPanel;
    public GameObject OptionsPanel;
    public GameObject ExitPanel;
    public GameObject MainPanel;

    [Header("BUTTON SOUNDS")]
    public AudioClip[] ButtonSounds;

    public Slider SoundSlider;

    private AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }
    

    public void PlayButton()
    {
        PlayPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        ExitPanel.SetActive(false);
        RandomButtonSound(Random.Range(0, 4));
    }

    public void OptionsButton()
    {
        OptionsPanel.SetActive(true);
        PlayPanel.SetActive(false);
        ExitPanel.SetActive(false);
        RandomButtonSound(Random.Range(0, 4));
    }

    public void ExitButton()
    {
        ExitPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        PlayPanel.SetActive(false);
        RandomButtonSound(Random.Range(0, 4));
    }

    public void MainPan()
    {
        MainPanel.SetActive(true);
        ExitPanel.SetActive(false);
    }

    public void ChangeSoundSlider(AudioSource source)
    {
        source.volume = SoundSlider.value;
        RandomButtonSound(Random.Range(0, 4));
    }

    private void RandomButtonSound(int rNo)
    {
        aSource.PlayOneShot(ButtonSounds[rNo]);
    }

    public void Yes()
    {
        Application.Quit();
        RandomButtonSound(Random.Range(0, 4));
    }

    public void No()
    {
        MainPan();
        RandomButtonSound(Random.Range(0, 4));
    }

    public void PlayGameScene(int sceneNo)
    {
        SceneManager.LoadScene("" + sceneNo + ".Level");


    }
    
}
