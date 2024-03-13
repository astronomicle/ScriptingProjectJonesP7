using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETeleportScript : MonoBehaviour
{
    void OnEnable()
    {
        EEventManager.OnClicked += Teleport;
    }

    void OnDisable()
    {
        EEventManager.OnClicked -= Teleport;
    }

    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
