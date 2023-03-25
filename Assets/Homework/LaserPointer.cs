using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    [SerializeField] List<Transform> points;

    private void Update()
    {
        Vector3 selfPos = transform.position;

        bool isHit = Physics.Raycast(transform.position, transform.up, out RaycastHit hitInfo);

        if (isHit)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Vector3 fullVect = hitInfo.point - selfPos;
                Vector3 step = fullVect / (points.Count - 1);
                Vector3 vect = i * step;
                Vector3 pos = selfPos + vect;

                points[i].position = pos;
                points[i].gameObject.SetActive(true);
            }

        }
        else 
        {
            foreach (Transform t in points)
            {
                t.gameObject.SetActive(false);
            }
        }
    }

    private void OnDrawGizmos()
    {
        bool isHit = Physics.Raycast(transform.position, transform.up, out RaycastHit hitInfo);
        
        if (isHit) 
        
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(hitInfo.point, transform.position);
        }
    }
}
