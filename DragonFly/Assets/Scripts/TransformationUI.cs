using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TransformationUI : MonoBehaviour
{
    public static IEnumerator DownOpacity(TextMeshProUGUI textToFade, float speedMultiplier)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;
        
        while (textToFade.color.a >= 0) // Тоже самое только затухание
        {
            speed = speedMultiplier * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = textToFade.color.a;
            currentFade -= speed;
            textToFade.color = new Color(textToFade.color.r, textToFade.color.g, textToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }

        if (textToFade.color.a == 0)
        {
            textToFade.enabled = false;
        }
    }
    public static IEnumerator DownOpacity(Image imageToFade)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;

        while (imageToFade.color.a >= 0) // Тоже самое только затухание
        {
            speed = 2 * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = imageToFade.color.a;
            currentFade -= speed;
            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }

        if (imageToFade.color.a == 0)
        {
            imageToFade.enabled = false;
        }
    }

    public static IEnumerator DownOpacity(TextMeshProUGUI imageToFade)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;

        while (imageToFade.color.a >= 0) // Тоже самое только затухание
        {
            speed = 2 * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = imageToFade.color.a;
            currentFade -= speed;
            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }

        if (imageToFade.color.a == 0)
        {
            imageToFade.enabled = false;
        }
    }

    public static IEnumerator DownOpacity(SpriteRenderer imageToFade, float stepTime)
    {
        float speed;
        float fadeTime = 0.5f;
        float currentFade;

        while (imageToFade.color.a >= 0) // Тоже самое только затухание
        {
            speed = 2 * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = imageToFade.color.a;
            currentFade -= speed;
            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }

        if (imageToFade.color.a == 0)
        {
            imageToFade.enabled = false;
        }
    }
    
    public static IEnumerator DownOpacity(CanvasGroup canvasGroup, float speedMultiplier)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;

        while (canvasGroup.alpha >= 0) // Тоже самое только затухание
        {
            speed = speedMultiplier * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = canvasGroup.alpha;
            currentFade -= speed;
            canvasGroup.alpha = currentFade;
            yield return new WaitForSeconds(stepTime);
        }

        if (canvasGroup.alpha == 0)
        {
            canvasGroup.enabled = false;
        }
    }
    
    public static IEnumerator HighOpacity(TextMeshProUGUI textToFade)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;
        textToFade.color = new Color(textToFade.color.r, textToFade.color.g, textToFade.color.b, 0);
        while (textToFade.color.a < 1) // Тоже самое только затухание
        {
            speed = 2 * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = textToFade.color.a;
            currentFade += speed;
            textToFade.color = new Color(textToFade.color.r, textToFade.color.g, textToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }
    }
    public static IEnumerator HighOpacity(Image imageToFade)
    {
        float speed;
        float fadeTime = 0.5f;
        float stepTime = 0.01f;
        float currentFade;
        imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, 0);
        while (imageToFade.color.a < 1) // Тоже самое только затухание
        {
            speed = 2 * (stepTime / fadeTime); // сколько отнимают = частоту отнимания / время отнимания
            currentFade = imageToFade.color.a;
            currentFade += speed;
            imageToFade.color = new Color(imageToFade.color.r, imageToFade.color.g, imageToFade.color.b, currentFade);
            yield return new WaitForSeconds(stepTime);
        }
    }
}

public class ChangeSize : TransformationUI
{
    public static  IEnumerator IncreaseScale(Button buttonToScale)
    {
        for (float q = 1f; q < 1.25f; q += .02f)
        {
            buttonToScale.transform.localScale = new Vector3(q, q, q);
            yield return new WaitForSeconds(.005f);
        }
    }
    public static  IEnumerator IncreaseScale(Image imageToScale)
    {
        for (float q = 1f; q < 1.25f; q += .02f)
        {
            imageToScale.transform.localScale = new Vector3(q, q, q);
            yield return new WaitForSeconds(.005f);
        }
    }
}
