using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {
    //public PlayerController parent;
    Collider C;
    // Use this for initialization
    void Start () {
        C = transform.parent.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            C.enabled = false;
            Debug.Log("Platform Check Works!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            C.enabled = true;
            Debug.Log("Platform Check Exitting!");
        }
    }
}
