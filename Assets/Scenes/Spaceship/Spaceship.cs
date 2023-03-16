using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] float acceleration = 5;

    Vector2 velocity;

    void Update()
    {
        bool forward = Input.GetKeyDown(KeyCode.UpArrow);
        
        if (forward) 
        {
            velocity += (Vector2)transform.up * (acceleration * Time.fixedDeltaTime);
        }

    }
}
