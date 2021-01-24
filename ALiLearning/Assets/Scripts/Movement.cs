using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   private Transform myTransform;
   
   public float maxSpeed = 5.0f;

   //Awake function will be the first one , that will be activated 
   private void Awake()
   {
        myTransform = GetComponent<Transform>();


   }
   
    //called once per frame
   private void Update()
   {
        myTransform.position += myTransform.forward * maxSpeed * Time.deltaTime;
       
   }


}
