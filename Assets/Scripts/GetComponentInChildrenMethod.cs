using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentInChildrenMethod : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        rb.velocity = new Vector3(1, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
