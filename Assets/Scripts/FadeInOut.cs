using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    Image blackField;

    void Start()
    {
        blackField = gameObject.GetComponent<Image>();
    }
    public IEnumerator FadeBlack(bool fadeIn, int fadeSpeed)
    {
        Color color = blackField.color;
        float fadeAmount;

        if (fadeIn)
        {
            while (blackField.color.a < 1)
            {
                fadeAmount = color.a + (Time.deltaTime / fadeSpeed);
                color = new Color(color.r,color.g,color.b,fadeAmount);
                gameObject.GetComponent<Image>().color = color;
                yield return null;
            }
        }
        else 
        {
            while (blackField.color.a > 0)
            {
                fadeAmount = color.a - (Time.deltaTime / fadeSpeed);
                color = new Color(color.r,color.g,color.b,fadeAmount);
                gameObject.GetComponent<Image>().color = color;
                yield return null;
            }
        }
    }
}
