using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aui : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip Scored;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "ball")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
            Debug.Log("hit");
        }
    }
}
