using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public GameObject normalDoor;
    public GameObject lockedDoor;
    bool locked = true;
    // Start is called before the first frame update
    void Start()
    {
        normalDoor.SetActive(false);
        lockedDoor.SetActive(true);
    }
    public void Unlock()
    {
        normalDoor.SetActive(true);
        lockedDoor.SetActive(false);   
        locked = false;
    }
}
