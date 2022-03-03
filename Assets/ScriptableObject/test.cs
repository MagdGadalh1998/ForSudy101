using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private ScriptableOb testScriptable;
    void Start()
    {
        Debug.Log(testScriptable.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
