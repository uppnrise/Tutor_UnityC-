using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int size;

    // if it is public everyone can access it
    // even from GUI of Unity.
    public int[] array;


    // Start is called before the first frame update
    void Start()
    {
        size = 10;
        array = new int[size];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
