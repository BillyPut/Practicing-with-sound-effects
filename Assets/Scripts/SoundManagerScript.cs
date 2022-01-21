using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] audioClips;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(int clipNumber)
    {
        
        audioSource.PlayOneShot(audioClips[clipNumber], 1f);

    }



}
