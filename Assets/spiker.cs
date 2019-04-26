using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            if (collision.gameObject.transform.position.x >= -12f && collision.gameObject.transform.position.x <= -5f)
            {
                collision.gameObject.transform.position = new Vector3(-11.17241f, -4.119288f, 1);
            }

            if (collision.gameObject.transform.position.x >= -5f && collision.gameObject.transform.position.x <= 0f)
            {
                collision.gameObject.transform.position = new Vector3(-5.28f, 3.845531f, 1);
            }




        }
    }
    
}