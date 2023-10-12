using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeycardPickup : MonoBehaviour {
    GameObject player;
    PlayerAccess playerAccess;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        Debug.Log(player.name);
        playerAccess = player.GetComponent<PlayerAccess>();
        Debug.Log(playerAccess);
    }

    //Item-Player Interaction on pickup - Override in child class for item specific behaviour
    public virtual void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
        // Adjust player attributes here...
            Debug.Log("collided");
            playerAccess.access += 1;
            Destroy(gameObject);
        }
    }
}