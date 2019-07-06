using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy a specific game object after 3 second!
        // Attach this script to a game object and it will destroy it.
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
