using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpMethods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int value = Evaluate(2);

        Debug.Log(value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Evaluate(int data)
    {
        Debug.Log("Evaluate");
        Debug.Log(data);

        return (data * 5);
    }
}
