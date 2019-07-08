using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabAndInstantiateMechanism : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This will create a huge amount of sphere game object so i commented it out
        // Instantiate(ball, transform.position, transform.rotation);
    }
}
