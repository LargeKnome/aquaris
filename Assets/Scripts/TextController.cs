using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public bool hasSeen = false;
    void OnBecameVisible()
    {
        hasSeen = true;
    }
    void OnBecameInvisible()
    {
        if (hasSeen)
        {
            gameObject.SetActive(false);
        }
    }
}
