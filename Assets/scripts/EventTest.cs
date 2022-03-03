using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public int First ,Second;
    public delegate void Calculate(int A, int B);
    void Start()
    {
        Calculate Test = null;
        Test += Sum;
        Test += Sub;
        Test += Multi;
        Test += new Calculate(delegate (int X, int Y) { Debug.Log("Div = " + (X / Y)); });
        Test += (X, Y) => Debug.Log("Cal = " + (X * Y * 5));
        Test(First, Second);
    }
    public void Sum(int X,int Y)
    {
        X = this.First;
        Y = this.Second;
        Debug.Log("Sum = " + (X + Y));
    }
    public void Sub(int X, int Y)
    {
        X = this.First;
        Y = this.Second;
        Debug.Log("Sub = " + (X -Y));
    }
    public void Multi(int X, int Y)
    {
        X = this.First;
        Y = this.Second;
        Debug.Log("Multi = " + (X * Y));
    }
}
