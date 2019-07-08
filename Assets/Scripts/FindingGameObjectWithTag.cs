using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingGameObjectWithTag : MonoBehaviour
{
    GameObject Quad;

    // Start is called before the first frame update
    void Start()
    {
        // Returns a single game object based on its "Tag"
        Quad = GameObject.FindWithTag("Quad");
        Destroy(Quad);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
