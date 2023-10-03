using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        playerPosition = transform.position;

        //Forwards and Back
        if (Input.GetKey("w")) {
            playerPosition.z = playerPosition.z + moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s")) {
            playerPosition.z = playerPosition.z - moveSpeed * Time.deltaTime;
        }

        //Strafing 
        if (Input.GetKey("a")) {
            playerPosition.x = playerPosition.x - moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("d")) {
            playerPosition.x = playerPosition.x + moveSpeed * Time.deltaTime;
        }

        //playerPosition = transform.position + Vector3.right* Time.deltaTime;
        
        transform.position = playerPosition;
        
    }
}
