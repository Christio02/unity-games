using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // variables
    public GameObject player; // gets player object
    private Vector3 offset = new Vector3(0, 7, -10); // sets camera default postion to follow player



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera whenever player is moving
        transform.position = player.transform.position + offset;
    }
}
