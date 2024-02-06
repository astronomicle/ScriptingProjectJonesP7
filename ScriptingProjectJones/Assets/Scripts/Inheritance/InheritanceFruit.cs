using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceFruit : MonoBehaviour
{
    public string color;

    public InheritanceFruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public InheritanceFruit(string newcolor)
    {
        color = newcolor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    // Update is called once per frame
    public void SayHello()
    {
        Debug.Log("Hello, I am Fruit.");
    }
}
