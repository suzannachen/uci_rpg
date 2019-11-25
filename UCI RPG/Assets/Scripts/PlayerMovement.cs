using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    //public float runSpeed = 40f;

    //float horizontalMove = 0f;
    
    public Animator animator;
    public Vector2 movementDirection;
    public float speed;


    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Move();
        Animate();
    }

    void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        speed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 5.0f);
        movementDirection.Normalize();
    }

    void Move()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        
        //transform.Translate(hor * speed * Time.deltaTime, ver * speed * Time.deltaTime, 0);
        //Debug.Log(hor);

        if (hor != 0)
        {
            transform.Translate(hor * speed * Time.deltaTime * 4, 0, 0);
        }

        else if (ver != 0)
        {
            transform.Translate(0, ver * speed * Time.deltaTime * 4, 0);
        }
    }

    void FixedUpdate()
    {
        // controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        //controller.Move(verticalMove * Time.fixedDeltaTime, false, false);
    }

    void Animate()
    {
        if (movementDirection != Vector2.zero)
        {
            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        }

        animator.SetFloat("Speed", speed);
    }
}
