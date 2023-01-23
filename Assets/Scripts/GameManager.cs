using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] int highscore;
    [SerializeField] int score;
    Storage storage;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highText;

    private void Start() {
        if (FindObjectOfType<Storage>() != null) {
            storage = FindObjectOfType<Storage>();
            highscore = storage.highscore;
        }
        UpdateHighscore();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            ResetScene();
        }
    }

    public void UpdateText() {
        scoreText.text = "" + score;       
    }

    public void AddPoorScore() {
        score += 50;
        UpdateHighscore();
        UpdateText();
    }

    public void AddGoodScore() {
        score += 100;
        UpdateHighscore();
        UpdateText();
    }

    public void AddPerfectScore() {
        score += 200;
        UpdateHighscore();
        UpdateText();
    }

    void UpdateHighscore() {

        if (score > highscore) {
            highscore = score;
        }
        highText.text = "" + highscore;
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
