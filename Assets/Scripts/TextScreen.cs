using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextScreen : MonoBehaviour
{
    public string nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadLevel());
    }
    public IEnumerator LoadLevel() {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(nextLevel);
    }
}
