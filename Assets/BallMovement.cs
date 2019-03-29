using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;

    private bool cutsceneMode = false;

    

    // Start is called before the first frame update
    void Start()
    {

    

    rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.J))
        {
            cutsceneMode = true;
        }

        if (Input.GetKey(KeyCode.Y))
        {
            cutsceneMode = false;
        }


        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(hMove, vMove);

        if (!(cutsceneMode == true)) {
            rb.AddForce(movement * Speed);
        }
    }

    
}
