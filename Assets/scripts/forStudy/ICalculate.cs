using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICalculate22<T>
{
    public void Calculate(T X1 , T x2);
}

public interface ICal:ICalculate22<int>
{

}