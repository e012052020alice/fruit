using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float RotateSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -RotateSpeed, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, RotateSpeed, 0);
    }

}
