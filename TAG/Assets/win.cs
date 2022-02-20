using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
   public void menu()
    {
        Debug.Log("menu");
        SceneManager.LoadScene("menu");
        
    }
    void Start()
    {
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
    }
}
