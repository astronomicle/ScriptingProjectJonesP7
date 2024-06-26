using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QMotionScript : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}
