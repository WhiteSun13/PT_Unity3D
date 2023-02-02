using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound : MonoBehaviour
{
    public AudioClip[] songs;

    public AudioSource audioSource;
    private int index;

    public void Hodit()
    {
        index = Random.Range(0, songs.Length);
        audioSource.PlayOneShot(songs[index]);
    }
}
