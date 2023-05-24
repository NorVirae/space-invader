using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletConroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("ShootBullet", 5.0f, 1.0f);
    }


    private void ShootBullet()
    {
        GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
