using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateArea : MonoBehaviour
{
    public double TotalArea(Shapes[] arrShapes)
    {
        double area = 0;
        foreach (var objShape in arrShapes)
        {
            area += objShape.calArea();
        }
        return area;
    }

}
public class Rectangle : Shapes
{
    public double Height { get; set; }
    public double Width { get; set; }
    
    public double calArea()
    {
        return Width*Height;
    }
}
public class Sphier :Shapes
{public double Rediues { get; set; }
    
    public double calArea()
    {
        return Rediues*Rediues*Mathf.PI;
    }
}
