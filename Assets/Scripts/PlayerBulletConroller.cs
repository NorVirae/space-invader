using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletConroller : MonoBehaviour

{
    public float interval = 1.0f;

    // Start is called before the first frame update
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }


    private void ShootBullet()
    {
        GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
