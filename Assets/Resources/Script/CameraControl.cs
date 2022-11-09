using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [HeaderAttribute("¬Û¾÷")]
    public Transform obj;
    public Vector3 offset;
    void Start()
    {

    }
    void Update()
    {
        transform.position = obj.position + obj.TransformDirection(offset);
        transform.LookAt(obj.transform.position);
    }
}
