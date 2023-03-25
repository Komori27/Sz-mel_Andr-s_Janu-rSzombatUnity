using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class FootStep : MonoBehaviour
{
    [SerializeField] AudioSource source;

    [SerializeField] List<AudioClip> clips;

    void PlaySound()
    {
        int index = Random.Range(0, clips.Count);
        AudioClip random = clips[index];

        source.clip = random;
        source.Play();
    }
}
