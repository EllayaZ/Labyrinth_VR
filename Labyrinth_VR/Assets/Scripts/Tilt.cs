using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public Transform explosionPrefab;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate (0, 0, 1);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -1);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-1, 0, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(1, 0, 0);

        }

    }
}
