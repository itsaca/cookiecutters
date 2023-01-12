using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    float cookieLifespan = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cookie lifespawn
        cookieLifespan -= Time.deltaTime;
        if (cookieLifespan < 0) {
            Destroy(gameObject);
        }

    }
}
