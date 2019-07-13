using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 75f;
    }

    // Update is called once per frame
    void Update()
    {
        // Keep pressing the horizantal and vertical set of keys and
        // you will move the attached object.
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(x * Time.deltaTime * speed, y * Time.deltaTime * speed, 0);
    }
}
