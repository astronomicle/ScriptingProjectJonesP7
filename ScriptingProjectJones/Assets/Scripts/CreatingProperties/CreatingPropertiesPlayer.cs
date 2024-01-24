using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPropertiesPlayer : MonoBehaviour
{
    //meber variables == fields
    private int experience;

    //experience == basic property
    public int Experience
    {
        get
        {
            //some other code
            return experience;
        }
        set
        {
            //some other code
            experience = value;
        }
    }

    //level == property that converts points to player's level automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //this == example of auto-implemented property
    public int Health { get; set; }
}
