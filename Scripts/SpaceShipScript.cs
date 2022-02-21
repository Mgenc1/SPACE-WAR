using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public float Speed;
    public float Xmax, Xmin;
    public float Ymax, Ymin;

    public GameObject BulletPrefab;
    public Transform BulletPos;

    public static  SpaceShipScript SpaceShip;
    public static bool isPaused = false;

    void Update()
    {
        Movement();
        ClampMovement();
        Rotation();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, Input.GetAxis("Vertical") * Speed * Time.deltaTime, 0f, Space.World);
    }

    void ClampMovement()
    {
        Vector3 ClampPos = transform.position;
        ClampPos.x = Mathf.Clamp(ClampPos.x, Xmax, Xmin);
        ClampPos.y = Mathf.Clamp(ClampPos.y, Ymax, Ymin);
        transform.position = ClampPos;
    }

    void Rotation()
    {
        transform.eulerAngles = new Vector3(-90f, 0f, -30f * Input.GetAxis("Horizontal"));
    }
    void Fire()
    {
        Instantiate(BulletPrefab, BulletPos.position, BulletPos.rotation);
        audioManager.AudioManager.PlayFire();
    }
}
