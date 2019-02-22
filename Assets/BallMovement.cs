using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;

    private float hMove = Input.GetAxis("Horizontal");
    private float vMove = Input.GetAxis("Vertical");

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = new Vector2(hMove, vMove);

        rb.AddForce(movement * Speed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wallx32")
        {
            rb.AddForce((movement * Speed) * - 0.8);
        }
    }
}
