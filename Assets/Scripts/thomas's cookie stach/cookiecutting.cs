using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecutting : MonoBehaviour
{
        public enum sweetspot {poor, good, perfect}
    public sweetspot ss;
    float cookieGoodness = -1;

    private void Update() {
        cookieGoodness += Time.deltaTime;

        if (cookieGoodness < -0.75f || cookieGoodness > 0.75f) {
            ss = sweetspot.poor;
        } else if (cookieGoodness > -0.25 || cookieGoodness < 0.25f) {
            ss = sweetspot.perfect;
        } else {
            ss = sweetspot.good;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "blade")
        {
            //Debug.Log("cookie got cut!");
            Destroy(gameObject);
        }
    }
}
