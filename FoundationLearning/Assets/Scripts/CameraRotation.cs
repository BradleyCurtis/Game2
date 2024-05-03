using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{


    public Vector3 offset;

    void Start()
    {
       
    }

    
    void Update()
    {
        gameObject.transform.position = GameObject.Find("Player").transform.position + offset;
    }
}
