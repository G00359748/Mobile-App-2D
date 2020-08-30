using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform helicopter;

    Vector3 velocity = Vector3.zero;

    public float smoothTime = .15f;


    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = helicopter.position;

        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
