using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    int healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthPoint = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoint < 1)
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Still fighting");
        }
    }
}
