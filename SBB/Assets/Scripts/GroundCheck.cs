using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public PlayerController P1; 
   // public float speed;

   // private Rigidbody rb;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
    
    }

    void OnTriggerEnter(Collider other)
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");

        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Ground Check Works!");
            P1.onGround = true;
            //Vector3 movement = new Vector3(moveHorizontal, 1.0f, 0.0f);

           // rb.AddForce(movement * speed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Ground Check Exitting!");
            P1.onGround = false;
        }
    }
}

