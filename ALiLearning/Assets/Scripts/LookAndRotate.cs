using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndRotate : MonoBehaviour
{
    private Transform myObject = null;
    public float rotationSpeed = 90.0f;
    public Transform target = null;

    private void Awake()
    {
        myObject = GetComponent<Transform>();
    }


    private void Update()
    {

        Quaternion destinationRotation = Quaternion.LookRotation(target.position - myObject.position, Vector3.up);

        myObject.rotation = Quaternion.RotateTowards(myObject.rotation , destinationRotation, rotationSpeed * Time.deltaTime);
        
    }
}
