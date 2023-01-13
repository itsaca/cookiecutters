using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public enum sweetspot {poor, good, perfect}
    public sweetspot ss;
    public RythmSync rs;
    float cookieLifespan = 4;
    float cookieGoodness;

    void Start()
    {
        cookieGoodness = -rs.variation;
    }

    void Update()
    {
        //cookieGoodness += Time.deltaTime;
        //if (cookieGoodness < -0.5 || cookieGoodness > 0.5) {
        //    ss = sweetspot.poor;
        //} else if (cookieGoodness < -0.3 || cookieGoodness > 0.3) {
        //    ss = sweetspot.good;
        //} else {
        //    ss = sweetspot.perfect;
        //}

        cookieLifespan -= Time.deltaTime;
        if (cookieLifespan < 0) {
            Destroy(gameObject);
        }

    }
}
