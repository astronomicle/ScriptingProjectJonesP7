using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHWarBand : MonoBehaviour
{
    void Start()
    {
        MHHumanoid human = new MHHumanoid();
        MHHumanoid enemy = new MHEnemy();
        MHHumanoid orc = new MHOrc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
