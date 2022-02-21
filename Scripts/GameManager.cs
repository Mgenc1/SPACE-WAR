using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    [Header("ROCK S SETTINGS")]
    public GameObject RockSprefab;
    public float StartRockS;
    public float BetweenRockS;

    [Header("ROCK L SETTINGS")]
    public GameObject RockLprefab;
    public float StartRockL;
    public float BetweenRockL;

    [Header("ROCK XL SETTINGS")]
    public GameObject RockXLprefab;
    public float StartRockXL;
    public float BetweenRockXL;

    [Header("FOLLOWSHIP")]
    public GameObject FollowShıpPrefab;
    public float StartFollowShıp;
    public float BetweenFollowShıp;

    [Header("DESTROYER1")]
    public GameObject Destroyer1Prefab;
    public float StartDestroyer1;
    public float BetweenDestroyer1;

    [Header("SPACESHIP")]
    public GameObject SpaceShipPrefab;



    private GameManager gameManager;
    private Scene scene;
    private bool isPausedLocal = false;



    private void Awake()
    {
        Singleton();
        scene = SceneManager.GetActiveScene();
    }


    void Start()
    {
        InstantiateSpaceShip();
        if (scene.name == "1.Level")
        {
            InvokeRepeating("InstantiateMeteorSprefab", StartRockS, BetweenRockS);
            InvokeRepeating("InstantiateMeteorLprefab", StartRockL, BetweenRockL);
            InvokeRepeating("InstantiateMeteorXLprefab", StartRockXL, BetweenRockXL);
        }
        else if (scene.name=="2.Level")
        {
            InvokeRepeating("InstantiateMeteorSprefab", StartRockS, BetweenRockS);
            InvokeRepeating("InstantiateMeteorLprefab", StartRockL, BetweenRockL);
            InvokeRepeating("InstantiateMeteorXLprefab", StartRockXL, BetweenRockXL);
            InvokeRepeating("InstantiateFollowShip", StartFollowShıp, BetweenFollowShıp);
        }
        else if (scene.name=="3.Level")
        {
            InvokeRepeating("InstantiateMeteorSprefab", StartRockS, BetweenRockS);
            InvokeRepeating("InstantiateMeteorLprefab", StartRockL, BetweenRockL);
            InvokeRepeating("InstantiateMeteorXLprefab", StartRockXL, BetweenRockXL);
            InvokeRepeating("InstantiateFollowShip", StartFollowShıp, BetweenFollowShıp);
            InvokeRepeating("InstantiateDestroyer1Ship", StartDestroyer1, BetweenDestroyer1);
        }
        
        
        
    }

    private void Update()
    {
        PauseUnpause();
    }



    private void Singleton()
    {
        if (gameManager==null)
        {
            gameManager=this;
        }
        else if (gameManager!=null)
        {
            Destroy(gameManager);
        }
    }

    public void PauseUnpause()
    {
        if (Input.GetKeyDown(KeyCode.P) && !isPausedLocal)
        {
            Time.timeScale = 0;
            SpaceShipScript.isPaused = true;
            isPausedLocal = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPausedLocal)
        {
            Time.timeScale = 1;
            SpaceShipScript.isPaused = false;
            isPausedLocal = false;
            
        }

    }
    ////////////////////////////////////////// INSTANTIATE PREFABS//////////////////////////////////////////////////////// 


    private void InstantiateSpaceShip()
    {
        Instantiate(SpaceShipPrefab, new Vector3(0f, -2.5f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }
    private void InstantiateMeteorSprefab()
    {
        Instantiate(RockSprefab, new Vector3(Random.Range(-6f, 6f), 8f, 0.26f), transform.rotation);
    }

    private void InstantiateMeteorLprefab()
    {
        Instantiate(RockLprefab, new Vector3(Random.Range(-6f, 6f), 8f, 0.26f), transform.rotation);
    }

    private void InstantiateMeteorXLprefab()
    {
        Instantiate(RockXLprefab, new Vector3(Random.Range(-6f, 6f), 8f, 0.26f), transform.rotation);
    }

    private void InstantiateFollowShip()
    {
        Instantiate(FollowShıpPrefab, new Vector3(Random.Range(-6f, 6f), 8f, 0.26f), Quaternion.Euler(-90f, 0f, 0f));
    }

    private void InstantiateDestroyer1Ship()
    {
        Instantiate(Destroyer1Prefab, new Vector3(Random.Range(-7f, 4.7f), 8f, 0.26f), Quaternion.Euler(-90f, 0f, 0f));
    }


}
