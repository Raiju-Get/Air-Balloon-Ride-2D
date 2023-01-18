using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondChild : IExample
{
    public  void run()
    {
        Debug.Log("run 2");
    }

    public  void walk()
    {
        Debug.Log("walk 2");
    }
}
