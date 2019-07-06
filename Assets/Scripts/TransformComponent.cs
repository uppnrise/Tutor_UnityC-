using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformComponent : MonoBehaviour
{
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        tempPos = transform.position;

        tempPos.x += 5f;
        // cannot change this value directly.
        // That is why we have to use a temporary variable.
        transform.position = tempPos;


        // Unity uses quaternions for rotation
        // increase x, y or z to change the rotation
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        Vector3 scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
