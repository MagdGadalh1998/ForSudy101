using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ForTeest test = new ForTeest(10, 20);
        ForTeest test2 = new ForTeest(1, 2, "OMDA");
        Debug.Log(test.x + " / " + test.y );
        Debug.Log(test2.x + " / " + test2.y + " / "+test2.Name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class ForTeest
{
    public int x, y;
    public string Name;
    public ForTeest(int A,int B,string C)
    {
        x = A;
        y = B;
        Name = C;
    }
    public ForTeest(int A, int B)
    {
        x = A;
        y = B;
    }
}
