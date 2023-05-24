using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreBulletsAndWallsController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullets")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            if(collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
