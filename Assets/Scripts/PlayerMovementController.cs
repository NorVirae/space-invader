using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    private Rigidbody2D rigidBody;
    private Animator animator;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log("V : " + v + " h: " + h);

        Vector2 dir = new Vector2(h, v);
        rigidBody.velocity = dir.normalized * speed;
        animator.SetBool("isFlyingLeft", h < 0);
        animator.SetBool("isFlyingRight", h > 0);

        animator.SetBool("isFlyingTop", v > 0);
        animator.SetBool("isFlyingBottom", v < 0);



    }


}
