using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimoneyController : MonoBehaviour
{

    public ParticleSystem dust;

    Animator animator;

    //Movement
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool isGrounded = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false; 
                createDust();

            }
           
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
            animator.SetFloat("Look X", 0.0f);
            createDust();
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
            animator.SetFloat("Look X", 1.0f);
        }


        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        animator.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.magnitude);

    }
    //Check if Grounded
    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void createDust()
    {
        dust.Play();
    }

}
