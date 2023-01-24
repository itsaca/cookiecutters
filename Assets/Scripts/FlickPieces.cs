using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickPieces : MonoBehaviour
{
    float piecesLifespan = 4;
    // Update is called once per frame
    void Update()
    {
        piecesLifespan -= Time.deltaTime;
        if (piecesLifespan < 0) {
            Destroy(gameObject);
        }
    }
}
