using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hum : MonoBehaviour
{
    testSetter test11 = new testSetter();
   enum Floors :int
    {F1,F2,F3,F4,F5}
    Floors floors;
    void Start()
    {
        test11.Age = 11;
        Debug.Log(test11.Age);
      //  Debug.Log(Floors.F1);
    }

    /*testSetter ForTestS = new testSetter();
    ForTestS.ID = 12;
    ForTestS.Name = "OMDA";
    ForTestS.Age = 16;

    Debug.Log(ForTestS.ID + "\n" +ForTestS.Name + "\n" +ForTestS.Age);*/
    void Update()
    {

    }

}

    // Update is called once per frame
    

public class testSetter : MonoBehaviour
{
    private int id;
    public int ID
        {
        set { this.id = value; }
        get { return this.id; }
        }
    private string myName;
    public string Name
    {
        set { this.myName = value; }
        get { return this.myName; }
    }
    public float Age { get; set; }

}
