using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public GameObject hitbox;
    bool open = false;
    bool changing = false;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && !open && !changing && Vector3.Distance(transform.position, player.transform.position) <= 4f) 
        {
            anim.SetTrigger("OpenDoor");
            hitbox.SetActive(false);
            StartCoroutine(ChangeState());
        }
        if (Vector3.Distance(transform.position, player.transform.position) >= 6f && !changing && open)
        {
            
            anim.SetTrigger("CloseDoor");
            hitbox.SetActive(true);
            StartCoroutine(ChangeState());
        }
    }
    IEnumerator ChangeState()
    {
        changing = true;
        yield return new WaitForSeconds(1);
        changing = false;
        open = !open;
    }
}
