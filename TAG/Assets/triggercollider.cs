using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggercollider : MonoBehaviour
{
  void OnCollisionEnter(Collision exampleCol) {
         if(exampleCol.collider.tag == "Obstacle")
         {
            //Replace 'Game Over' with your game over scene's name.
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("gameover");
         }
    }
}
