using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBullet1 : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.Translate(0f, -Time.deltaTime * Speed, 0f, Space.World);
        if (transform.position.y <= -7f)
            Destroy(gameObject);
    }

}    
