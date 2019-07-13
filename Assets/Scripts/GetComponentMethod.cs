using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentMethod : MonoBehaviour
{
    /*
     * We are able to get access to a component of a gameobject
     * with GetComponent method. Even you can create an object
     * from a random class and initialize it with GetComponent method.
     */

    Rigidbody rigidBody;
    BoxCollider boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
