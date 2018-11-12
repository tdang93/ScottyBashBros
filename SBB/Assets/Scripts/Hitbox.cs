using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitbox : MonoBehaviour {
    public PlayerController parent;
    public GameObject fist;
    public Text winText;
    //public CameraControls camera;
    Collider C;
    Collider F;
    // Use this for initialization
    void Start () {
        C = parent.GetComponent<Collider>();
        F = fist.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            C.enabled = false;
            F.enabled = false;
            Debug.Log("Platform Check Works!");
        }
        if (other.gameObject.tag == "Deathblock")
        {
            parent.gameObject.SetActive(false);
            fist.gameObject.SetActive(false);
            Debug.Log("Deathblock works!");
            winText.text = "Game! The Winner is...YOU!";
        }
        if(other.gameObject.tag == "Fist")
        {
            Vector3 damage = new Vector3(1f, 1f, 0.0f);
            parent.transform.Translate(damage);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            C.enabled = true;
            F.enabled = true;
            Debug.Log("Platform Check Exitting!");
        }
        if (other.gameObject.tag == "Deathblock")
        {
            parent.gameObject.SetActive(false);
            fist.gameObject.SetActive(false);
            Debug.Log("Deathblock works!");
            winText.text = "Game! The Winner is...YOU!";
        }
        if (other.gameObject.tag == "Fist")
        {
            Vector3 damage = new Vector3(-1f, 1f, 0.0f);
            parent.transform.Translate(damage);
        }
    }
}


        