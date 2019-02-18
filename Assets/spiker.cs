using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ballx32")
        {
            Destroy(collision.gameObject);
        }
    }
    
}