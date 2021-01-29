using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPresss : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Ali");
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("space"))
      {
          Debug.Log("Updating");
      }

      if(Input.GetKey("left"))
      {
          Debug.Log("Left Move");
      }

      if(Input.GetKey("right"))
      {
          transform.position += Vector3.right * speed * Time.deltaTime;
      }
    }
}
