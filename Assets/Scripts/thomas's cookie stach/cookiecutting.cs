using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookiecutting : MonoBehaviour
{
        public enum sweetspot {poor, good, perfect}
    public sweetspot ss;
    float cookieGoodness = -1f;
    GameManager gm;
    public GameObject pieces;

    private void Start() {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Update() {
        cookieGoodness += Time.deltaTime;

        if (cookieGoodness > -0.25f && cookieGoodness < 0.25f) {
            ss = sweetspot.perfect;
        } else if (cookieGoodness < -0.75f || cookieGoodness > 0.75f) {
            ss = sweetspot.poor;
        } else {
            ss = sweetspot.good;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "blade")
        {
            if (ss == sweetspot.poor) {
                gm.AddPoorScore();
                gm.cookieslashing(1);
            }

            if (ss == sweetspot.good) {
                gm.AddGoodScore();
                gm.cookieslashing(1);

            }

            if (ss == sweetspot.perfect) {
                gm.AddPerfectScore();
                gm.cookieslashing(2);
                //gm.combo();

            }

            Instantiate(pieces, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
