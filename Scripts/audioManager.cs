using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static audioManager AudioManager;

    [Header("SOURCES")]
    public AudioSource FireSource;
    public AudioSource RocksExplosionSource;
    public AudioSource PlayExplosionFollowShipSource;
    public AudioSource Destroyer1ExplosionSource;

    [Header("CLIPS")]
    public AudioClip FireClip;
    public AudioClip RocksExplosionClip;
    public AudioClip ExplosionFollowShipClip;
    public AudioClip Destroyer1ExplosionClip;

    void Start()
    {
        Singleton();
    }

    
    private void Singleton()
    {
        if (AudioManager != null)
        {
            Destroy(gameObject);
        }
        else 
        {
            AudioManager = this;
        }
    }
    public void PlayFire()
    {
        FireSource.clip = FireClip;
        FireSource.PlayOneShot(FireClip);
    }
    public void PlayExplosionRocks()
    {
        RocksExplosionSource.clip = RocksExplosionClip;
        RocksExplosionSource.PlayOneShot(RocksExplosionClip);
    }
    public void PlayExplosionFollowShip()
    {
        PlayExplosionFollowShipSource.clip = ExplosionFollowShipClip;
        PlayExplosionFollowShipSource.PlayOneShot(ExplosionFollowShipClip);
    }

    public void PlayExplosionDestroyer1()
    {
        Destroyer1ExplosionSource.clip = Destroyer1ExplosionClip;
        Destroyer1ExplosionSource.PlayOneShot(Destroyer1ExplosionClip);
    }
}
