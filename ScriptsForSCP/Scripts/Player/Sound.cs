using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Player
{
    public class Sound : MonoBehaviour
    {
        public AudioClip clip;
        public AudioSource audioSource;
        private float volume;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }
        public void PlaySound(AudioClip sound)
        {
            audioSource.PlayOneShot(sound, volume);
        }


    }
}