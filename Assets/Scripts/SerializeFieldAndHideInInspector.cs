using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeFieldAndHideInInspector : MonoBehaviour
{
    // we can't access it from another class/script
    // but we can assign a value from GUI/Scene Screen.
    [SerializeField]
    private int value;

    // if we want to hide in inspector a public field,
    // use below tag.
    [HideInInspector]
    public int value1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
