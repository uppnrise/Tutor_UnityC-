using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatingMethod : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        // call inst, 1 time in 1 second.
        InvokeRepeating("inst", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void inst()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
