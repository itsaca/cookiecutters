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
    int i;
    public float variation;

    void FixedUpdate() {
        currentPos = nav.position.x;
        if (i < beats.Length) {
            beatPos = beats[i].transform.position.x;
            CreateCookieTimeline();
            if (currentPos >= beatPos) {
                i++;
                sm.SpawnCookie();
            }
        } return;
    }

    void CreateCookieTimeline() {
        variation = Random.Range(0.3f, 2);
        beatPos -= variation;
    }

}
