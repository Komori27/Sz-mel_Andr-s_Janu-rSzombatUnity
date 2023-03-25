using System.Collections.Generic;
using UnityEngine;

class ArrayHomework : MonoBehaviour
{
    [SerializeField] float[] testArray = new float[0];
    [SerializeField] List<float> testList = new List<float>();
    [SerializeField] float mean;
    [SerializeField] float min;

    [SerializeField] int length = 10;
    [SerializeField] int[] testArray2 = new int[0];

    void OnValidate()
    {
        mean = Mean(testArray);
        testArray2 = Fill(length);


        min = Mathf.Min(1, 2, 3, 3, 4, 5);
        min = Mathf.Min(min);
        min = Min(1, 2, 3, 3, 4);
        min = Min(testArray);
    }


    float Mean(float[] array)
    {
        float sum = 0;

        foreach (float e in array)
        {
            sum += e;
        }

        return sum / array.Length;
    }

    float Mean(List<float> list)
    {
        float sum = 0;

        foreach (float e in list)
        {
            sum += e;
        }

        return sum / list.Count;
    }

    int[] Fill(int length)
    {
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = i + 1;
        }
        /*
        for (int i = 1; i <= length; i++)
        {
            result[i-1] = i;
        }
        */

        return result;
    }


    float Min(params float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float min = array[0];
        for (int i = 1; i < length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }


    void Practice()
    {
        /*
        int a;          // Not nullable
        GameObject go;  // Nullable

        Debug.Log(a);   // nem def
        Debug.Log(go);  // nem def

        string s1;          // Nem def
        string s2 = null;   // Null
        string s3 = "";     // 0 elemû string
        */
    }

}
