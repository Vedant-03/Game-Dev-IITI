using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
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
