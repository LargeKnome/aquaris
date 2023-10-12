using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public int occlusionRange = 20;
    public int forwardBias = 2;
    GameObject[] lights;
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("Light");
    }

    // Update is called once per frame
    void Update()
    {
        for (int n = 0; n < lights.Length; n++)
        {
             

            if (Vector3.Distance(gameObject.transform.position + Vector3.forward*forwardBias, lights[n].transform.position) >= occlusionRange)
            {
                lights[n].SetActive(false);
            }
            else
            {
                lights[n].SetActive(true);
            }
        }
    }
}
