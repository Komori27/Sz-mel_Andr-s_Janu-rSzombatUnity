using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class MyFirstUnityScript : MonoBehaviour
{
    void Start()
    {
        Vector2 v1;
        v1 = new Vector2(2, 4);

        float x = v1.x;

        Debug.Log(x);

        v1 = v1 * 3;
       
        Debug.Log(v1.x);      //  6
        Debug.Log(v1.y);      //  12

        Vector2 v2 = new Vector2(3, 1);

        Vector2 v3 = v1 + v2;   //  (9, 13)

        Debug.Log(v3.x);     //  9
        Debug.Log(v3.y);     //  13

        Vector3 va = new Vector3(1.234f, 2.456f, 3);

        va *= 5;

        Vector3 zero1 = new Vector3(0, 0, 0);
        Vector3 zero2 = Vector3.zero;

        Vector3 up1 = new Vector3(0, 1, 0);
        Vector3 up2 = Vector3.up;

        Vector3 forward = Vector3.forward;  //  (0, 0, 1)
        Vector3 back = Vector3.back;        //  (0, 0, -1)

        Vector3 left = Vector3.left;        //  (-1, 0, 0)
        Vector3 right = Vector3.right;      //  (1, 0, 0)


        up1 /= 2;

        float mag = va.magnitude;       // magnitude --- hossz
        
        Vector3 vaNorm = va.normalized;     // lekérem a normalizált vektort
        va.Normalize();                     // a vektor innentõl normalizált (hossz = 1)

        float distance = (v1 - v2).magnitude;           //  távolság
        float distance2 = Vector2.Distance(v1, v2);     
    }
}
