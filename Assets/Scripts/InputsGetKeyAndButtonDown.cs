using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsGetKeyAndButtonDown : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if space putton pressed execute something.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, transform.position, transform.rotation);
        } // Edit->Project Settings->Input
          // Some of the control buttons are already assigned and is usable as String parameter.
        else if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Space pressed");
        }
    }
}
