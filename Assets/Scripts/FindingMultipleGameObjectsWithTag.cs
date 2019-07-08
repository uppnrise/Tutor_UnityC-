using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingMultipleGameObjectsWithTag : MonoBehaviour
{
    GameObject[] QuadArray;

    // Start is called before the first frame update
    void Start()
    {
        QuadArray = GameObject.FindGameObjectsWithTag("Quad");

        foreach (GameObject g in QuadArray)
            Destroy(g.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
