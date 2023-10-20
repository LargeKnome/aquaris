using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    public GameObject thisObject;
    public Vector3 rotation;
    public float rotationSpeed;
    public bool On;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (On == true)
        {
            Rotate();
        }
        else
        {

        }
    }

    void Rotate()
    {
        thisObject.transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }
}
