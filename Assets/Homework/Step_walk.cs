using UnityEngine;

class Step_walk : MonoBehaviour
{

    [SerializeField] float speed = 5;
    [SerializeField] float stepLength = 2;

    Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        bool up = Input.GetKeyDown(KeyCode.UpArrow);
        bool down = Input.GetKeyDown(KeyCode.DownArrow);
        bool right = Input.GetKeyDown(KeyCode.RightArrow);
        bool left = Input.GetKeyDown(KeyCode.LeftArrow);

        Vector2 step;

        if (right)
            step = Vector2.right;
        else if (left)
            step = Vector2.left;
        else if (up)
            step = Vector2.up;
        else if (down)
            step= Vector2.down;
        else
            step = Vector2.zero;


        targetPosition += (Vector3) step * stepLength;
        //------mozgás---------

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed*Time.deltaTime);
    }
}
