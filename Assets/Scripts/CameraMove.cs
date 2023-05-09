using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject plane;
    public float offset;

    void Update()
    {
        transform.position = new Vector3(plane.transform.position.x+offset, transform.position.y, transform.position.z);
      
    }
}
