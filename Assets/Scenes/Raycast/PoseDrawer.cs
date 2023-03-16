using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PoseDrawer : MonoBehaviour
{
    [SerializeField] float size = 1;

    void OnDrawGizmos()
    {
        Vector3 point = transform.position;
        Vector3 right = transform.right;
        Vector3 up = transform.up;
        Vector3 forward = transform.forward;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(point + right*size, point - right*size);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(point + up * size, point - up * size);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(point + forward * size, point - forward * size);
    }
}
