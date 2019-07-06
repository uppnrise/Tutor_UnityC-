using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWithTranslateMethod : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // A good way of moving an object is to use translate method.
        // if you don't use Time.deltaTime object will move too fast.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
