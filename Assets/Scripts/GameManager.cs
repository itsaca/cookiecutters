using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int highscore;
    [SerializeField] int score;
    Storage storage;

    private void Start() {
        if (FindObjectOfType<Storage>() != null) {
            storage = FindObjectOfType<Storage>();
            highscore = storage.highscore;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            ResetScene();
        }
    }

    public void AddPoorScore() {
        score += 50;
        UpdateHighscore();
    }

    public void AddGoodScore() {
        score += 100;
        UpdateHighscore();
    }

    public void AddPerfectScore() {
        score += 200;
        UpdateHighscore();
    }



    void UpdateHighscore() {

        if (score > highscore) {
            highscore = score;
        }

    }

    public void ResetScene() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

        if (GameObject.Find("DontDestroy") == null) {
            var dontDestroy = new GameObject("DontDestroy");
            dontDestroy.AddComponent<Storage>();
        }

        var storage = GameObject.FindObjectOfType<Storage>();

        score = 0;
        storage.highscore = highscore;
    }
}
