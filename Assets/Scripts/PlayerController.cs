using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Private variables
    private float speed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    


    // Start is called before the first frame update
    void Start() {
    
        
    }

    // Update is called once per frame
    void Update() {

        // Get player input for turning and speed

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // We make the vehicle forward

       transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);

       // We make the vehicle turn
       transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
