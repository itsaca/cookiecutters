using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmSync : MonoBehaviour
{
    public List<MusicBeat> beats;
    public SpawnerManager sm;
    public Transform nav;
    float currentPos;
    float beatPos;
    int i;
    public float variation;

    private void Awake() {
        CollectBeats();
    }

    void Update() {

        currentPos = nav.position.x;
        if (i < beats.Count) {
            beatPos = beats[i].transform.position.x;
            CreateCookieTimeline();
            if (currentPos >= beatPos) {
                i++;
                sm.SpawnCookie();
            }
        } return;
    }

    void CreateCookieTimeline() {
        variation = Random.Range(0.3f, 1f);
        beatPos -= variation;
    }

    void CollectBeats() {
        var beatarray = GetComponentsInChildren<MusicBeat>();
        beats = new List<MusicBeat>(beatarray);
        beats.Sort(CompareBeats);
    }

    int CompareBeats(MusicBeat a, MusicBeat b) {
        var ax = a.transform.position.x;
        var bx = b.transform.position.x;
        if (ax < bx) return -1;
        if (ax > bx) return 1;
        return 0;


    }
}
