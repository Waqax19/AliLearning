using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards : MonoBehaviour
{
    private Transform myTransform;

    public float rotationSpeed = 90f;

    private void Awake()
    {
        myTransform = GetComponent<Transform>();
    }

    private void Update()
    {

        myTransform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.up);
    }
}
