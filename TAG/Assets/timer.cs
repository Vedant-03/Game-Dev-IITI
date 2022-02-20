using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float timevalue =30;
    public Text timetext;
   

    // Update is called once per frame
    void Update()
    {
        if(timevalue>0)
        {
        timevalue -= Time.deltaTime;
        }
        else{
            SceneManager.LoadScene("gameover");
        }
        DisplayTime(timevalue);
        
    }
    void DisplayTime(float timetoDisplay)
    {
        if(timetoDisplay<0)
        {
            timetoDisplay=0;
            
        }
        float minutes =Mathf.FloorToInt(timetoDisplay/60);
        float seconds =Mathf.FloorToInt(timetoDisplay%60);
        timetext.text= string.Format("{0:00}:{1:00}" ,minutes,seconds);
    
    }
}
