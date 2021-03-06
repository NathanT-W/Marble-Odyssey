﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;

    public bool cutMode = false;
    

    // Start is called before the first frame update
    void Start()
    {

    rb = GetComponent<Rigidbody2D>();
        
    }

    void cutModeOn()
    {
        cutMode = true;
    }

    void cutModeOff()
    {
        cutMode = false;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(hMove, vMove);

       
        rb.AddForce(movement * Speed);
        
    }

    
}
