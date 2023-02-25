using UnityEngine;

public class Step_count : MonoBehaviour
{
    [SerializeField] Vector2 a, b;

    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;
    
    private void OnValidate()       //OnValidate csak a szerkesztõben fut le
    {
        Vector2 v = b - a;

        float length = v.magnitude;
        stepCount = Mathf.CeilToInt(length);

        step = v / stepCount;
    }
}
