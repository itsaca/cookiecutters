using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Storage : MonoBehaviour
{
    public int highscore;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }
}
