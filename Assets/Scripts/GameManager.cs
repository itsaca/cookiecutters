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
    [SerializeField] private TextMeshProUGUI Combo;
    public AudioSource killsound;
    public AudioSource perfkillsound;
    public AudioSource meow;
    public int comboNumber = 3;
    public int currentcombo=0;
    public GameObject combogif;
    [SerializeField] int poor;
    [SerializeField] int good;
    [SerializeField] int perfect;

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
        poor += 1;
        UpdateHighscore();
        UpdateText();
    }

    public void AddGoodScore() {
        score += 100;
        good += 1;
        UpdateHighscore();
        UpdateText();
    }

    public void AddPerfectScore() {
        score += 200;
        perfect += 1;
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

    public void cookieslashing(float a)
    {
        if (a == 1.0f) 
        {
            killsound.Play();
        }
        if (a== 2.0f)
        {
            perfkillsound.Play();
        }


    }

    public void combo()
    {
        currentcombo += 1;
        if (currentcombo == comboNumber) 
        {
            Instantiate(combogif);
            meow.Play();
            currentcombo= 0;
            
        }
        Combo.text = "Combo:" + currentcombo;
    }


}
