<<<<<<< HEAD
<<<<<<< HEAD
using System.Collections;
=======
﻿using System.Collections;
>>>>>>> parent of 35b96b2... Fix the mess
=======
﻿using System.Collections;
>>>>>>> parent of 35b96b2... Fix the mess
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator animator;
<<<<<<< HEAD
<<<<<<< HEAD
    public bool doorOpen;
=======
    bool doorOpen;
   
>>>>>>> parent of 35b96b2... Fix the mess
=======
    bool doorOpen;
   
>>>>>>> parent of 35b96b2... Fix the mess

    public GameObject inactiveWires;

    public GameObject activeWires;

<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject inactiveButton;

    public GameObject activeButton;
=======
=======
>>>>>>> parent of 35b96b2... Fix the mess
    public GameObject thisDoor;



<<<<<<< HEAD
>>>>>>> parent of 35b96b2... Fix the mess
=======
>>>>>>> parent of 35b96b2... Fix the mess

    public void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
<<<<<<< HEAD
<<<<<<< HEAD
            if (doorOpen == false)
            {
                doorOpen = true;
                DoorState("Open");

                inactiveWires.SetActive(false);
                activeWires.SetActive(true);
                activeButton.SetActive(true);
                inactiveButton.SetActive(false);

            }

            if (collision.gameObject.transform.position.x > 12f)
            {
                activeWires.SetActive(false);
            }

        }
    }

    public void DoorState(string Direction)
    {
        animator.SetTrigger(Direction);
=======
=======
>>>>>>> parent of 35b96b2... Fix the mess
            doorOpen = true;
            //DoorState("Open");

            inactiveWires.SetActive(false);
            activeWires.SetActive(true);

            thisDoor.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    public void DoorState(string Open)
    {
        animator.SetTrigger(Open);
<<<<<<< HEAD
>>>>>>> parent of 35b96b2... Fix the mess
=======
>>>>>>> parent of 35b96b2... Fix the mess
    }
}
