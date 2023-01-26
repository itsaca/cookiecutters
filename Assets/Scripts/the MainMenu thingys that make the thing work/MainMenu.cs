using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene( 1);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void QuiteGame()
    {
        Application.Quit();
    }
}
