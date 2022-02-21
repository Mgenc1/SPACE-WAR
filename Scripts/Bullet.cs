using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;

    [Header("EFFECTS")]
    public GameObject RockEffects;
    public GameObject FollowShipEffect;
    public GameObject Destroyer1Effect;


    void Update()
    {
        transform.Translate(0f,0f, Speed * Time.deltaTime);
    }

    private void DestroyBullet()
    {
        if (transform.position.y>6.3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        
        if (other.gameObject.tag=="RockS")
        {
            UImanager.Score += 30;
            MeteorsFX();
            audioManager.AudioManager.PlayExplosionRocks();
        }
        else if (other.gameObject.tag=="RockL")
        {
            UImanager.Score += 20;
            MeteorsFX();
            audioManager.AudioManager.PlayExplosionRocks();
        }
        else if (other.gameObject.tag=="RockXL")
        {
            UImanager.Score += 10;
            MeteorsFX();
            audioManager.AudioManager.PlayExplosionRocks();
        }
        else if (other.gameObject.tag== "FollowShip")
        {
            UImanager.Score += 40;
            FollowShipFX();
            audioManager.AudioManager.PlayExplosionFollowShip();
        }
        else if (other.gameObject.tag=="Destroyer1")
        {
            UImanager.Score += 50;
            Destroyer1FX();
            audioManager.AudioManager.PlayExplosionDestroyer1();
        }
        
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    ////////////////////////////////////////////////////////EFFECTS//////////////////////////////////////////////////
    

    public void MeteorsFX()
    {
        Instantiate(RockEffects, transform.position, transform.rotation);
    }

    public void FollowShipFX()
    {
        Instantiate(FollowShipEffect, transform.position, transform.rotation);
    }
    
    public void Destroyer1FX()
    {
        Instantiate(Destroyer1Effect, transform.position, transform.rotation);
    }
}
