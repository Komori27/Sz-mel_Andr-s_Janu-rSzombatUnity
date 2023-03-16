using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    [SerializeField] Material mouseOverMaterial;

    Material mat;

    private void OnMouseEnter()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        if (mr == null)
            return;

        mat = mr.material;
        mr.material = mouseOverMaterial;
    }

    private void OnMouseExit()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>(); 
        if (mr == null) return;

        mr.material = mat;
    }
}
