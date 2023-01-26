using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    GameManager gm;
    // Start is called before the first frame update
    public void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void Pause()
    {
        pausemenu.SetActive(true);
        gm.music.Pause();
        Time.timeScale = 0.0f;
    }
    public void Resume()
    {
        pausemenu.SetActive(false);
        gm.music.UnPause();
        Time.timeScale = 1.0f;
    }
    public void Quite()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
}
