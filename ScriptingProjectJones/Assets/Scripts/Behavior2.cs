using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
