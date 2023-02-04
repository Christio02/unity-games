using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // variables
    public GameObject player; // gets player object
    public GameObject cam1;
    public GameObject cam2;
    private Vector3 offset1 = new Vector3(0, 7, -10); // sets camera default postion to follow player

    private Vector3 firstP = new Vector3(0, 5, 1);
    


    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera whenever player is moving
        transform.position = player.transform.position + offset1;
        
        if (Input.GetButtonDown("Cam1")) { 
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

        if (Input.GetButtonDown("Cam2")) {
            offset1 = firstP;
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
