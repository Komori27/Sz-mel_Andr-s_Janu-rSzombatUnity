using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] float speed;
    //[SerializeField] Mover mover;             //változik a projectile speed a shooter sebességével

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 startPos = transform.position;
            Quaternion direction = transform.rotation;

            GameObject newGo = Instantiate(projectile);
            newGo.transform.position = startPos;
            newGo.transform.rotation = direction;

            Rigidbody rb = newGo.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed; //+ mover.GetVelocity();
        }
    }
}
