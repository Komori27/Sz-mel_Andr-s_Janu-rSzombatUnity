using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class SphereLimit : MonoBehaviour
{
    [SerializeField] Vector3 center;
    [SerializeField] float radius;

    private void Update()
    {
        Vector3 point = transform.position;

        float distance = Vector3.Distance(center, point);

        if (distance > radius) 
        {
            Vector3 offset = point - center;
            offset.Normalize();
            offset *= radius;

            transform.position = center + offset;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1,1,1, 0.15f);

        Gizmos.DrawSphere(center, radius);
    }

}
