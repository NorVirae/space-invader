using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject gameObject = GameObject.FindWithTag("Player");
        Vector3 playerPos = (gameObject.transform.position - transform.position).normalized;
        //Debug.Log("x: " + playerPos.x + " y: " + playerPos.y);
        Vector2 bulletNewPos = new Vector2( playerPos.x, playerPos.y);
        GetComponent<Rigidbody2D>().velocity = bulletNewPos * speed;
    }


 
}
