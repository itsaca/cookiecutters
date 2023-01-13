using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmSync : MonoBehaviour
{
    public GameObject[] beats;
    public SpawnerManager sm;
    public Transform nav;
    float currentPos;
    float beatPos;
    int index;
    int i = 0;

    void FixedUpdate() {
        currentPos = nav.position.x;
        if (i < beats.Length) {
            beatPos = beats[i].transform.position.x;
            if (currentPos >= beatPos) {
                i++;
                sm.SpawnCookie();
            }
        } return;
    }

}
