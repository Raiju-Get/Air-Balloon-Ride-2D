using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildClass : IExample
{
    public  void run()
    {
        Debug.Log("run");
    }

    public  void walk()
    {
        Debug.Log("walk");
    }
}
