using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public CharacterController _controller;
        public bool isCrouching = false;
        
         public float standingHeight = 1.8f;
     public float crouchingHeight = 1.25f;
     
   
   
    // Start is called before the first frame update
    void Start()
    {
      _controller = GetComponent<CharacterController>();
        
    }
     
     

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
         if (isCrouching == true)
        {
            _controller.height = crouchingHeight;
           
        }
        else
        {
            _controller.height = standingHeight;
        }

    }
}
