using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator animator;
    bool doorOpen;
   

    public GameObject inactiveWires;

    public GameObject activeWires;



    public void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            doorOpen = true;
            //DoorState("Open");

            inactiveWires.SetActive(false);
            activeWires.SetActive(true);

        }
    }

    public void DoorState(string Open)
    {
        animator.SetTrigger(Open);
    }
}
