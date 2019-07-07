using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagsInUnityCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.tag == "Quad")
        {
            Debug.Log("This is a quad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
