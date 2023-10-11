using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Terminal : MonoBehaviour
{
    public GameObject unlockedMesh;
    public GameObject lockedMesh;

    public UnityEvent onActivation;
    bool activated = false;
    
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
            lockedMesh.SetActive(true);
            unlockedMesh.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && Vector3.Distance(transform.position, player.transform.position) <= 2f && !activated) 
        {
            onActivation.Invoke();
            activated = true;
            lockedMesh.SetActive(false);
            unlockedMesh.SetActive(true);
        }
    }
}
