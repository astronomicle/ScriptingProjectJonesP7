using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceApple : InheritanceFruit
{
    public InheritanceApple()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public InheritanceApple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
