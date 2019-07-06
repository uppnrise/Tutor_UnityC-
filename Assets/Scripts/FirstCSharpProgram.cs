using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 If you want to render something to screen your class needs
 to inherit from Unity's MonoBehaviour base class.
 */
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
