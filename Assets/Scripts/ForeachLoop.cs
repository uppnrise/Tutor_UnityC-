using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    public int[] array;

    // Start is called before the first frame update
    void Start()
    {
        // 
        foreach(int i in array)
        {
            Debug.Log(i);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
