using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETurnColorScript : MonoBehaviour
{
    void OnEnable()
    {
        EEventManager.OnClicked += TurnColor;
    }

    void OnDisable()
    {
        EEventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}
