using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverridingFruitSalad : MonoBehaviour
{
    void Start()
    {
        OverridingApple myApple = new OverridingApple();
        myApple.SayHello();
        myApple.Chop();

        OverridingFruit myFruit = new OverridingFruit();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
