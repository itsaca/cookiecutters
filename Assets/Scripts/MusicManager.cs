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

    public AudioSource music;
    GameManager gm;
    public float percentageComplete = 0;

    void Start() {
        timeline = gameObject.transform.Find("Timeline");
        nav = gameObject.transform.Find("Nav");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        PrepareTimeline();
        music = GetComponent<AudioSource>();
        
    }

    void Update() {
      

        if (musicON) 
        {
            elapsedTime += Time.deltaTime;
            percentageComplete = elapsedTime / musicTrackLenght;
            nav.transform.position = Vector3.Lerp(navStartPosition, navEndPosition, percentageComplete);
        }

        if (percentageComplete >= 1) {
            gm.Levelend();
        }

    }


    void PrepareTimeline() {
        timeline.transform.localScale += new Vector3(musicTrackLenght, 0, 0);
        timeline.transform.position += new Vector3(timeline.transform.localScale.x / 2, 0, 0);
        navStartPosition = nav.transform.position;
        navEndPosition = timeline.transform.position * 2;
    }
}
