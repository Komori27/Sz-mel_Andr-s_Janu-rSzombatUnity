using UnityEngine;

class AutoRotation : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;
    //[SerializeField] ;
    [SerializeField] Space space = Space.World;

    void Update()
    {
        transform.Rotate(0, angularSpeed *Time.deltaTime, 0);
    }
}
