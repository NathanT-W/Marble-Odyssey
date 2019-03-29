using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;

    public bool cutsceneMode = false;

    

    // Start is called before the first frame update
    void Start()
    {

    

    rb = GetComponent<Rigidbody2D>();
        
    }

    public bool CutsceneModeOn()
    {
        return cutsceneMode = true;
    }

    public bool CutsceneModeOff()
    {
        return cutsceneMode = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.J))
        {
            CutsceneModeOn();
        }

        if (Input.GetKey(KeyCode.Y))
        {
            CutsceneModeOff();
        }


        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(hMove, vMove);

        if (!(cutsceneMode == true)) {
            rb.AddForce(movement * Speed);
        }
    }

    
}
