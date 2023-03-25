using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    int collectedValue = 0;
    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();

        if (collectable != null) 
        {
            collectedValue += collectable.value;
            collectable.Collect();
            Debug.Log(collectedValue);
        }
    }
}
