using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator animator;
    bool doorOpen;
   
    public GameObject inactiveWires;

    public GameObject activeWires;

    public GameObject thisDoor;

    public GameObject inactiveButton;

    public GameObject activeButton;


    public void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (doorOpen == false)
            {
                doorOpen = true;
                DoorState("Open");

                inactiveWires.SetActive(false);
                activeWires.SetActive(true);
                activeButton.SetActive(false);
                inactiveButton.SetActive(true);
            }

        }
    }

    public void DoorState(string Open)
    {
        animator.SetTrigger(Open);
    }
}
