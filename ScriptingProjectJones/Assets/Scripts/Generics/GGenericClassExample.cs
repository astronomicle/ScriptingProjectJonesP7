using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGenericClassExample : MonoBehaviour
{
    void Start()
    {
        GGenericClass<int> myClass = new GGenericClass<int>();

        myClass.UpdateItem(5);
    }
}
