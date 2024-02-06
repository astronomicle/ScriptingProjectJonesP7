using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceFruitSalad : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Creating the fruit");
        InheritanceFruit myFruit = new InheritanceFruit();
        Debug.Log("Creating the apple");
        InheritanceApple myApple = new InheritanceApple();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new InheritanceFruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new InheritanceApple("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }
}
