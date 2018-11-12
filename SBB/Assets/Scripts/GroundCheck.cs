using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundCheck : MonoBehaviour {
    public PlayerController parent;
    public GameObject Fist;
    public Hitbox combat;
    public Text winText;

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
            parent.onGround = true;
            Debug.Log("Ground Check Works!");
        }
        if (other.gameObject.tag == "Platform")
        {
            parent.onPlatform = true;
            Debug.Log("Platform Check Works!");
        }
        if (other.gameObject.tag == "Deathblock")
        {
            parent.gameObject.SetActive(false);
            Debug.Log("Deathblock works!");
            winText.text = "Game! The Winner is...YOU!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Platform")
        {
            parent.onGround = false;
            parent.onPlatform = false;
            Debug.Log("Ground Check Exiting!");
        }
        if(other.gameObject.tag == "Deathblock")
        {
            parent.gameObject.SetActive(false);
            Fist.gameObject.SetActive(false);
            Debug.Log("Deathblock works!");
            winText.text = "Game! The Winner is...YOU!";
        }
    }
}

/* else if ((parent.moveVertical< 0.0) && (parent.onGround = true))
        {
            C.enabled = false;
            Debug.Log("Drop Works!");
        } */
