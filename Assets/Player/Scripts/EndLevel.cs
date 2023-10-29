using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public string nextLevel;
    // Start is called before the first frame update
    public void End()
    {
        GameManager.instance.levelComplete = true;
        StartCoroutine(GameManager.instance.LoadLevel(nextLevel));
    }
}
