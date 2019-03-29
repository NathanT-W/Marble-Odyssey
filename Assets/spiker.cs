using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiker : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.position = new Vector3Int(-17,4,1);
        }
    }
    
}