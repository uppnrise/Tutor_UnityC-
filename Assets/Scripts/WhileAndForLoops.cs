using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileAndForLoops : MonoBehaviour
{

    int counter = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (counter != 0)
        {
            Debug.Log("value of counter = " + counter);
            counter--; // counter = counter - 1;
        }

        Debug.Log("outside of while loop, before for loop");

        for(int i = 0 ; i < 5 ; i++)
        {
            Debug.Log("value of i: " + i);
        }

        Debug.Log("outside of for and while loop, after for loop");
    }
}
