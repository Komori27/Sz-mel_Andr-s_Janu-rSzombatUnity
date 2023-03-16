using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildRotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    private void Update()
    {
        MeshRenderer[] children = GetComponentsInChildren<MeshRenderer>();

        float angle = angularSpeed* Time.deltaTime;
        Vector3 position = transform.position;

        foreach (MeshRenderer child in children)
        {
            if (child.gameObject != gameObject)
            {
                Transform childT = child.transform;
                float distance = Vector3.Distance(childT.position, position);

                childT.Rotate(Vector3.up, angle, Space.Self);
            }
        }
    }
}
