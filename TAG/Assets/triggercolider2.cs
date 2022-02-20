using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggercolider2 : MonoBehaviour
{
    void OnCollisionEnter(Collision exampleCol)
    {
        
        if (exampleCol.collider.tag == "Player")
        {
            Debug.Log("You Win");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("victory");
        }
    }
}
