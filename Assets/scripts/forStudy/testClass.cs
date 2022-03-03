using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testClass : MonoBehaviour
{
    Sum sumtion = new Sum();
    MultiPlication multi = new MultiPlication();
    Sub Subset = new Sub();
    [SerializeField]
    private int X;
    [SerializeField]
    private int Y;


    void Start()
    {
        sumtion.Calculate(X,Y);
        multi.Calculate(X,Y);
        Subset.Calculate(X, Y);
    }

}
public class MultiPlication :ICal
{
    
    public void Calculate(int A,int B)
    {
        Debug.Log("Multi = " + A * B);
    }
}
public class Sum :ICal
{
    
    public void Calculate(int A,int B)
    {
        Debug.Log("Sum = " + (A+B));
    }
}
public class Sub :ICal
{
    public void Calculate(int A,int B)
    {
        Debug.Log("Sub = " + (A - B));
    }
}