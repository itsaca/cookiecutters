using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOver;

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }

    public void Quite()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
