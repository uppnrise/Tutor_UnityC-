using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingAndSizeChange : MonoBehaviour
{
    public float xScale = 1f;
    public Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        temp.x = 1f;
        temp.y = 1f;
        temp.z = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // We can't transform localScale value directly.
        // We need to create a temporary Vector to do it.
        temp.x += (xScale * Time.deltaTime);
        transform.localScale = temp;

    }
}
