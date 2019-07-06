using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAndUpdateMethod : MonoBehaviour
{
    /* Start is called before the first frame update
     * and only one time.
     * Only called if script is enabled.
     */
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
