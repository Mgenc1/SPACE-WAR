using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipHealth : MonoBehaviour
{
    public int Health;
    public GameObject[] HealthAll;
    public GameObject HealthPrefab;
    private GameObject HealthParent;
    
    void Start()
    {
        HealthAll = new GameObject[Health];
        HealthParent = GameObject.FindGameObjectWithTag("HealthParent");
        for (int i = 0; i < HealthAll.Length; i++)
        {
            GameObject UpParent = Instantiate(HealthPrefab);
            UpParent.transform.SetParent(HealthParent.transform);
            HealthAll[i] = UpParent;
        }
    }

    
   
    private void OnTriggerEnter(Collider other)
    {
        Health--;
        

        if (Health > 0)
        {
            HealthAll[Health].SetActive(false);
        }
        else if (Health <= 0)
        {
            HealthAll[0].SetActive(false);
            Destroy(gameObject);
        }

        if (other.gameObject.tag=="RockS")
        {
            Destroy(other.gameObject);
            
        }
        else if (other.gameObject.tag == "RockL")
        {
            Destroy(other.gameObject);
            
        }
        else if (other.gameObject.tag == "RockXL")
        {
            Destroy(other.gameObject);
            
        }
        else if (other.gameObject.tag == "DestroyerBullet1")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag=="Destroyer1")
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "FollowShip")
        {
            Destroy(other.gameObject);

        }

    }
}
