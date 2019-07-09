using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesInCSharp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float waitTime = 5f;
        StartCoroutine(coRoutineTest(waitTime));
        StartCoroutine("coRoutineTest", waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // if you a method wait and execute again
    // you can use a coroutine.
    IEnumerator coRoutineTest(float waitTime)
    {
        Debug.Log("coRoutine Started");

        yield return new WaitForSeconds(5f);

        Debug.Log("coRoutine Ended");
    }
}
