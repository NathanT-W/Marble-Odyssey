using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject activeWires1;
    public GameObject activeWires2;
    
    private int checkPointPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && checkPointPosition == 0)
        {
            collision.gameObject.transform.position = new Vector3(-11.17241f, -4.08f, 1);
            transform.position = new Vector3(-9.17f, -0.08f, -10);
            activeWires1.SetActive(false);
        }

        if (collision.gameObject.name == "Player" && checkPointPosition == 1)
        {
            collision.gameObject.transform.position = new Vector3(-5.28f, 3.8455f, 1);
            transform.position = new Vector3(-3.17f,-0.08f, -10);
            activeWires2.SetActive(false);
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
