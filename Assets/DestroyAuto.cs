using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAuto : MonoBehaviour
{
    [SerializeField] float destroyTime = 5;

    [SerializeField] AudioSource audioSource;

    /*
    float bornTime;

    private void Start()
    {
        bornTime= Time.time;
    }

    private void Update()
    {
        if(Time.time > bornTime + destroyTime) 
        {
            Destroy(gameObject);
        }
    }
    */
    private void Start()
    {
        //Destroy(gameObject, destroyTime);
        Invoke(nameof(DestroySelf), destroyTime);
    }

    void DestroySelf()
    {
        audioSource.Play();
        Debug.Log(".");
        Destroy(gameObject, destroyTime);
    }
}
