using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class RotateMobile : MonoBehaviour
{
    public bool isActive = false;
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
      
           // activeColor = Color.red;
 
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);
 
                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(screenTouch.deltaPosition.y*rotateSpeed, 0f, 0f);
                }
 
                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        
    }
}
