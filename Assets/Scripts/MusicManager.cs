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

    GameManager gm;
    float percentageComplete;

    void Start() {
        timeline = gameObject.transform.Find("Timeline");
        nav = gameObject.transform.Find("Nav");
        gm = GameObject.Find("GameManager1").GetComponent<GameManager>();
        PrepareTimeline();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            StartMusic();
        }

        if (musicON) {
            elapsedTime += Time.deltaTime;
            percentageComplete = elapsedTime / musicTrackLenght;
            nav.transform.position = Vector3.Lerp(navStartPosition, navEndPosition, percentageComplete);
        }

        if (percentageComplete >= 1) {
            gm.LevelCompleted();
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
}
