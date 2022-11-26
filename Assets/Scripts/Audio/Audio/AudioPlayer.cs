using System;
using UnityEngine;
using UnityEngine.Video;

namespace Script
{
    public class AudioPlayer : MonoBehaviour
    {
       
        [SerializeField] private AudioSource audioSource;

        public void Play(AudioClip audioClip)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}