using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float additiveDist;
    public float inverseMultiplier;
    public Vector3 offset;
    public GameObject target;
    public GameObject camera; 
    LayerMask mask;
    // Start is called before the first frame update+
    void Start()
    {
        mask = LayerMask.GetMask("CameraAvoid");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;
        RaycastHit hit;

        Vector3 cameraPos;

        if (Physics.Raycast(transform.position, -Vector3.Normalize(offset), out hit, 100f, mask))
        {
            float playerDist = Vector3.Distance(target.transform.position, hit.point);
            float distance = inverseMultiplier/playerDist;

            cameraPos = hit.point + Vector3.Normalize(offset) * (distance + additiveDist);
        }
        else
        {
            cameraPos = target.transform.position + Vector3.Normalize(offset) * 4;
        }

        camera.transform.position = cameraPos;
    }
}
