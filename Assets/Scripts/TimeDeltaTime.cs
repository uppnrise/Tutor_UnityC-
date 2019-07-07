using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeltaTime : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* 
         * Time.deltaTime : The amount of time took to render the last frame.
         * In our case, we are multiplying 5f * 1/60 seconds(speed * Time.deltaTime(1 frame is getting called in 1/60sn))
         * This equals to how much we are moving per frame.
         */
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
