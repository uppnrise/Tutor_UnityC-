using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeMethod : MonoBehaviour
{
    // Gets called before Start()
    // Called everytime even if script is not enabled.
    void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    // Only called if script is enabled.
    // Gets called after Awake()
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
