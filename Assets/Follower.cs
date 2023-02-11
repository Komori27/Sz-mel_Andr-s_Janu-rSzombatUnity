using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEditor.Build.Content;
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    //[SerializeField] float sineAmp = 0.1f;
    //[SerializeField] float sineFreqMultiplier = 5;
    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition - selfPosition;
        //direction.Normalize();

        /*
        //  Sin
        float sine = Mathf.Sin(Time.time * sineFreqMultiplier);
        sine *= sineAmp;
        sine += 1;
        direction *= sine;
        */

        //Vector3 velocity = direction * speed;
        //transform.position += velocity * Time.deltaTime;

        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);

        if (direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);
    }
}
