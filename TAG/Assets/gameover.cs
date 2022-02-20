using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    
    public void Restart()
    {
        Debug.Log("MENU");
        SceneManager.LoadScene("menu");
    }
   
    public void QuitGame()
    {
         Debug.Log("quit");
        Application.Quit();
    }
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
    }

}
