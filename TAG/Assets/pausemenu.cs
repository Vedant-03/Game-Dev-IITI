using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pausemenuUI;

    public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused= false;
    }
    public void pause()
    {
       pausemenuUI.SetActive(true);
       Time.timeScale=0f;
       GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu");
        SceneManager.LoadScene("menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting Menu");
        Application.Quit();
    }

    void Start()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Update()
    {
        if(GameIsPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
}
