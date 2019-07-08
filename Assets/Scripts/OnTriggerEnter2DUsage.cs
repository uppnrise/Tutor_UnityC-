using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter2DUsage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Use it when you have a trigger game object which
    // allows you to pass through inside.
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "trig")
            Destroy(collision.gameObject);
    }
}
