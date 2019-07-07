using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGameObjects : MonoBehaviour
{
    public float rot = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(5f, rot, 0);
    }
}
