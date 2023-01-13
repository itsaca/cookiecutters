using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    Transform timeline;
    Transform nav;
    public float musicTrackLenght;

    public bool musicON = false;
    Vector3 navEndPosition;
    Vector3 navStartPosition;
    float elapsedTime;

    void Start() {
        timeline = gameObject.transform.Find("Timeline");
        nav = gameObject.transform.Find("Nav");
        PrepareTimeline();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            StartMusic();
        }

        if (musicON) {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / musicTrackLenght;
            nav.transform.position = Vector3.Lerp(navStartPosition, navEndPosition, percentageComplete);
        }

    }

    void StartMusic() {
        musicON = true;
    }

    void PrepareTimeline() {
        timeline.transform.localScale += new Vector3(musicTrackLenght, 0, 0);
        timeline.transform.position += new Vector3(timeline.transform.localScale.x / 2, 0, 0);
        navStartPosition = nav.transform.position;
        navEndPosition = timeline.transform.position * 2;
    }

    //void CookieTimeline[]{}
}
