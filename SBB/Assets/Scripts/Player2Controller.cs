using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    public float speed;
    public float jumpSpeed;
    public bool onGround = false;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //TestInputs();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Switch Horizontal");
        float moveVertical = 0;

        if (onGround == true)
        {
            moveVertical = Input.GetAxis("Switch Vertical");
            Vector3 jump = new Vector3(0.0f, moveVertical, 0.0f);
            rb.AddForce(jump * jumpSpeed);
        }
        else
        {
            moveVertical = 0;

        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        rb.AddForce(movement * speed);
    }

    void TestInputs()
    {
        if (Input.GetAxisRaw("P1 H") != 0)
        {
            Debug.Log("P1 H");
        }
        if (Input.GetAxisRaw("P1 V") != 0)
        {
            Debug.Log("P1 V");
        }
        if (Input.GetAxisRaw("P1 A") != 0)
        {
            Debug.Log("P1 A");
        }
        if (Input.GetAxisRaw("P1 B") != 0)
        {
            Debug.Log("P1 B");
        }
        if (Input.GetAxisRaw("P1 X") != 0)
        {
            Debug.Log("P1 X");
        }
        if (Input.GetAxisRaw("P1 Y") != 0)
        {
            Debug.Log("P1 Y");
        }
        if (Input.GetAxisRaw("Mouse X") != 0)
        {
            Debug.Log("Mouse X");
        }
        if (Input.GetAxisRaw("Mouse Y") != 0)
        {
            Debug.Log("Mouse Y");
        }
        if (Input.GetAxisRaw("Mouse ScrollWheel") != 0)
        {
            Debug.Log("Mouse ScrollWheel");
        }
        if (Input.GetAxisRaw("P3 H") != 0)
        {
            Debug.Log("P3 H");
        }
        if (Input.GetAxisRaw("P3 V") != 0)
        {
            Debug.Log("P3 V");
        }
    }
}
