using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayMap1()
    {
        SceneManager.LoadScene("map01");
    }
    public void PlayMap2()
    {
        SceneManager.LoadScene("map02");
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("settingsmenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
