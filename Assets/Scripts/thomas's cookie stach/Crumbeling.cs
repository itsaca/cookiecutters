using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumbeling : MonoBehaviour
{
    public float fadeDelay = 10f;
    public float alphaValue = 0;
    public bool destroyGameObject = false;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer= GetComponent<SpriteRenderer>();
        StartCoroutine(FadeTo(alphaValue,fadeDelay));

    }

    IEnumerator FadeTo(float aValue,float fadetime)
    {
        float alpha = spriteRenderer.color.a; 

        for (float t =0.0f;t<1.0f;t+=Time.deltaTime/fadetime)
        {
            Color newColor =new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, Mathf.Lerp(alpha, aValue, t));
            spriteRenderer.color = newColor;
            yield return null;
        }

        if (destroyGameObject) 
        {
            Destroy(gameObject);
        }




    }


}
