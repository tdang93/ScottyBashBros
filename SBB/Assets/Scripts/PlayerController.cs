using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Fist;

    public bool left;
    public float speed;
    public float jumpSpeed;
    public float dropSpeed;
    //public float punchSpeed;
    public float moveVertical = 0;
    public float moveHorizontal = 0;
    public bool onGround = false;
    public bool onPlatform = false;
    public Collider C;

    public Rigidbody rb;

	// Use this for initialization
	public void Start () {
        rb = GetComponent<Rigidbody>();
        C = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	public void FixedUpdate () {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        if (onGround == true || onPlatform == true)
        {
            Vector3 jump = new Vector3(0.0f, moveVertical, 0.0f);
            rb.AddForce(jump * jumpSpeed);
        }
        if(onPlatform == true)
        {
            if(moveVertical < 0)
            {
                C.enabled = false;
                Vector3 drop = new Vector3(0.0f, -moveVertical, 0.0f);
                rb.AddForce(drop * dropSpeed);
                Debug.Log("Drop Works!");
            }
        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        rb.AddForce(movement * speed);

        if (Input.GetAxis("Fire1") != 0)
        {
            
            Vector3 punch = new Vector3(-0.5f, 0.0f, 0.0f);

            Vector3 recoil = new Vector3(0.5f, 0.0f, 0.0f);
            Fist.transform.Translate(punch);
            Fist.transform.Translate(recoil);
            Debug.Log("PUNCH");
            //Rigidbody rb = Fist.GetComponent<Rigidbody>();
            //rb.AddForce(punch * punchSpeed);
        }

        if (Input.GetAxis("Fire2") != 0)
        {

            Vector3 punch = new Vector3(0.5f, 0.0f, 0.0f);

            Vector3 recoil = new Vector3(-0.5f, 0.0f, 0.0f);
            Fist.transform.Translate(punch);
            Fist.transform.Translate(recoil);
            Debug.Log("PUNCH");
            //Rigidbody rb = Fist.GetComponent<Rigidbody>();
            //rb.AddForce(punch * punchSpeed);
        }
    }

    //if (Input.GetKeyDown(KeyCode.Space))

}

