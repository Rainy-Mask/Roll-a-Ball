using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    public Vector3 distance;
    void Start()
    {
        distance = transform.position - ball.transform.position;
    }

    void LateUpdate()
    {
        transform.position = ball.transform.position + distance;
    }
}
