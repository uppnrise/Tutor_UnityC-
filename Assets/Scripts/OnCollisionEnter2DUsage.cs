using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnter2DUsage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Getting called if attached object gets collided with something.

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colliding");
        // if collided object has a tag name "nacar", destroy it.
        if(collision.gameObject.tag == "nacar")
        {
            Destroy(collision.gameObject);
        }
    }
}
