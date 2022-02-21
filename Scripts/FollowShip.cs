using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShip : MonoBehaviour
{
    public float Speed;
    private GameObject SpaceShip;
    

    void Start()
    {
        SpaceShip = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        FollowShipMesafe();
        DestroyFollowShip();
    }
    
    void DestroyFollowShip()
    {
        if (transform.position.y<=-7f)
        {
            Destroy(gameObject);
        }
    }

    void FollowShipMesafe()
    {

        if (SpaceShip != null)
        {
            Vector3 Distance = SpaceShip.transform.position - transform.position;
            transform.position += Distance.normalized * Speed * Time.deltaTime;
            transform.LookAt(SpaceShip.transform);
        }
        else if (SpaceShip == null)
        {
            transform.eulerAngles = Vector3.zero;
            transform.position += Vector3.down * Time.deltaTime;
        }
        
    }
    
}
