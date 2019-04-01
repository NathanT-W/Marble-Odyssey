using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorShut : MonoBehaviour
{
    public Animator animator;
    bool doorOpen;

  

    public void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ballx32")
        {
            doorOpen = false;
            DoorState("Close");
        }
    }

    public void DoorState(string Close)
    {
        animator.SetTrigger(Close);
    }
}
