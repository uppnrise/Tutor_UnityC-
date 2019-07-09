using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left mouse button pressed.");

            Vector3 mousePos = Input.mousePosition;

            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right mouse button pressed.");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Middle mouse button pressed.");
        }


    }
}
