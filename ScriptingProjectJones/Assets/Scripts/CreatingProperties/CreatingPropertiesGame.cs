using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPropertiesGame : MonoBehaviour
{
    private void Start()
    {
        CreatingPropertiesPlayer myPlayer = new CreatingPropertiesPlayer();

        //properties can be used like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
        Debug.Log(x);
    }
}
