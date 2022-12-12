using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed;
    public float dampAmt;

    void Update()
    {
        transform.Rotate((Vector3.up * rotationSpeed) * (Time.deltaTime * dampAmt), Space.Self);
    }
}

