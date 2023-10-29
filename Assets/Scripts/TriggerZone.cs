using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{

    public UnityEvent onActivation;
    public virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.transform.name);
        onActivation.Invoke();
        gameObject.SetActive(false);
    }
}
