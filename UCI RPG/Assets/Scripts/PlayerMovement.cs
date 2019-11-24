using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController2D controller;

    //public float runSpeed = 40f;

    //float horizontalMove = 0f;
    int speed = 4;

    //float verticalMove = 0f;


    // Update is called once per frame
    void Update()
    {
        // horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        //transform.Translate(hor * speed * Time.deltaTime, ver * speed * Time.deltaTime, 0);

        //Debug.Log(hor);

        if (hor != 0)
        {
            transform.Translate(hor * speed * Time.deltaTime, 0, 0);
        }

        else if (ver != 0)
        {
            transform.Translate(0, ver * speed * Time.deltaTime, 0);
        }

    }

    void FixedUpdate()
    {
        // controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        //controller.Move(verticalMove * Time.fixedDeltaTime, false, false);
    }
}
