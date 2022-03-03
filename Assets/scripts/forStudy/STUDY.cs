using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STUDY : MonoBehaviour
{
    public string A1, A2;
    public int X, Y;
    // Start is called before the first frame update
    void Start()
    {
        testMultiGeneric<int, string>(5,"hello Every One");
        int[] intArray = myArray<int>(X, Y);
        string[] strArr = myArray<string>(A1, A2);
        Debug.Log(intArray.Length + "  " + intArray[0] + "  " + intArray[1]);
        Debug.Log(strArr.Length + "  " + strArr[0] + "  " + strArr[1]);

    }
    void Update()
    {
        
    }
    T [] myArray<T>(T FElement ,T SElement)
    {
        return new T[] { FElement, SElement };
    }
    void testMultiGeneric<T1,T2>(T1 t1,T2 t2)
    {
        Debug.Log(t1);
        Debug.Log(t2);
    }

}
