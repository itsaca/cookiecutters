using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
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
