using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] Bounds bounds;
    [SerializeField] public int value = 5;
    [SerializeField] bool startAtRandomPosition;

    void Awake()
    {
        if(startAtRandomPosition) 
        {
            Teleport();
        }
    }



    public void Collect() 
    {
        Teleport();
    }

    void Teleport() 
    {
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        Vector3 p = new Vector3(x,y,z);

        transform.position = p;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}
