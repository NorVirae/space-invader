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
        if (gameObject != null)
        {
            Vector2 bulletNewPos = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = bulletNewPos * speed;
        }
       
        //Debug.Log("x: " + playerPos.x + " y: " + playerPos.y);
        
    }


 
}
