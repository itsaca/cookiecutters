using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public enum sweetspot {poor, good, perfect}
    public sweetspot ss;
    public RythmSync rs;
    float cookieLifespan = 4;

    void Start()
    {

    }

    void Update()
    {
        cookieLifespan -= Time.deltaTime;
        if (cookieLifespan < 0) {
            Destroy(gameObject);
        }

    }
}
