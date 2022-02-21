using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockL : MonoBehaviour
{
    public float Speed;

    
    void Update()
    {
        transform.Translate(0f, -Speed * Time.deltaTime, 0f);
        transform.Rotate(0, 45 * Time.deltaTime * Speed, 0);
        DestroyRockL();
    }

    void DestroyRockL()
    {
        if (transform.position.y<=-7f)
        {
            Destroy(gameObject);
        }
    }
}
