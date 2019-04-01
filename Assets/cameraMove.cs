<<<<<<< HEAD
using System.Collections;
=======
﻿using System.Collections;
>>>>>>> parent of 35b96b2... Fix the mess
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{

<<<<<<< HEAD
    public GameObject activeWires;
=======
    
>>>>>>> parent of 35b96b2... Fix the mess

    private int checkPointPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && checkPointPosition == 0)
        {
            collision.gameObject.transform.position = new Vector3(-11.17241f, -4.119288f, 1);
<<<<<<< HEAD
            transform.position = new Vector3(-9.17f, 0, -10);
            activeWires.SetActive(false);
=======
            transform.position = new Vector3(-8.17f, 0, -10);
>>>>>>> parent of 35b96b2... Fix the mess
        }

        if (collision.gameObject.name == "Player" && checkPointPosition == 1)
        {
            collision.gameObject.transform.position = new Vector3(-4.25866f, -4.119288f, 1);
            transform.position = new Vector3(-1.17f, 0, -10);
        }
        checkPointPosition += 1;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        */
    }
}
