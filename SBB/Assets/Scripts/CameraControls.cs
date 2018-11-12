using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public GameObject camera;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    Vector3 minXY;
    Vector3 maxXY;
    float distance;
    //public float numPlayers = 0;

    float player1x;
    float player2x;
    float player3x;
    float player4x;

    float player1y;
    float player2y;
    float player3y;
    float player4y;

    float minAx;
    float minBx;
    float minCx;
    float maxAx;
    float maxBx;
    float maxCx;

    float minAy;
    float minBy;
    float minCy;
    float maxAy;
    float maxBy;
    float maxCy;

    private Vector3 offset;
    private Vector3 cameraPosition;
    private Vector3 cameraMove; 
    private Vector3 zoom;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //offset = Vector3.Max(player.transform.position, player2.transform.position);
        //offset = transform.position + player.transform.position;
        /*if(player1.activeInHierarchy == false)
        {
            player1x = 0;
            player1y = 0;
        }*/
      
        player1x = player1.transform.position.x;
        player1y = player1.transform.position.y;

        player2x = player2.transform.position.x;
        player2y = player2.transform.position.y;

        player3x = player3.transform.position.x;
        player3y = player3.transform.position.y;

        player4x = player4.transform.position.x;
        player4y = player4.transform.position.y;
        
        maxAx = Mathf.Max(player1x, player3x);
        maxBx = Mathf.Max(player2x, player4x);
        maxCx = Mathf.Max(maxAx, maxBx);

        minAx = Mathf.Min(player1x, player3x);
        minBx = Mathf.Min(player2x, player4x);
        minCx = Mathf.Min(minAx, minBx);

        maxAy = Mathf.Max(player1y, player3y);
        maxBy = Mathf.Max(player2y, player4y);
        maxCy = Mathf.Max(maxAy, maxBy);

        minAy = Mathf.Min(player1y, player3y);
        minBy = Mathf.Min(player2y, player4y);
        minCy = Mathf.Min(minAy, minBy);

        minXY = new Vector3(minCx, minCy, 0);
        maxXY = new Vector3(maxCx, maxCy, 0);

        cameraPosition = (minXY + maxXY) / 2.0F;
        //camera.transform.position = cameraPosition;
        //Debug.Log(minCx);
        //Debug.Log(minCy);
        //Debug.Log(maxCx);
        //Debug.Log(maxCy);

        //cameraMove = (player.transform.position + player2.transform.position + player3.transform.position + player4.transform.position) / 4.0F;

        distance = (maxXY - minXY).magnitude;

        distance = distance * 1F;

        zoom = new Vector3(0,0,-distance);

        camera.transform.position = cameraPosition + zoom;
    }
}

/*if (numPlayers == 2)
       {
           transform.position = player.transform.position + offset;
       }
       if (numPlayers == 3)
       {

       }
       if (numPlayers == 4)
       {

       }*/
//transform.position = PlayerDistance + offset;