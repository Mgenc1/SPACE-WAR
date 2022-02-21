using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RokcS : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.Translate(0f, -Speed * Time.deltaTime, 0f);
        DestroyRockS();
    }

    void DestroyRockS()
    {
        if (transform.position.y <= -7f)
        {
            Destroy(gameObject);
        }
    }
}
