using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;

    void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPaused= false;

    }
    void pause()
    {
       pausemenuUI.SetActive(true);
       Time.timeScale=0f;
       GameIsPaused = true;
    }

    void update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                resume() ;
            }
            else{
                pause();
            }
        }
    }
    

}
