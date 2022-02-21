using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer1 : MonoBehaviour
{
    public float Speed;
    public GameObject BulletPrefab;
    public Transform BulletPos;
    public float StartBullet;
    public float BetweenBullet;

    void Start()
    {
        InvokeRepeating("İnstantiateBullet", StartBullet, BetweenBullet);
    }

    
    void Update()
    {
        transform.Translate(0f, -Time.deltaTime * Speed, 0f, Space.World);
        if (transform.position.y<=-7f)
        {
            Destroy(gameObject);
        }
    }
    
    void İnstantiateBullet()
    {
        Instantiate(BulletPrefab, BulletPos.position, BulletPos.rotation);
    }
}
