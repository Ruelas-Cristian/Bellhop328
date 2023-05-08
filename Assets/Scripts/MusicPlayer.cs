using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Sound.MusicPlayer {
    [RequireComponent(typeof (AudioSource))]

    public class MusicPlayer : MonoBehaviour {
        [Header("Audio Clips")]
        [SerializeField] AudioClip[] clips;
        private AudioSource audioSource;

        [Header("Fadeing settings")]
        [SerializeField] float durationIn;
        [SerializeField] float targetVolumeIn;

        // Start is called before the first frame update
        void Start() {
            audioSource = this.gameObject.GetComponent<AudioSource>();
            audioSource.volume = 0;

            audioSource.loop = false;
        }

        // Update is called once per frame
        void Update() {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = GetRandomClip();
                StartCoroutine(FadeAudioSource.StartFade(audioSource, durationIn, targetVolumeIn));
                audioSource.Play();
            }
        }

        private AudioClip GetRandomClip() {
            return clips[Random.Range(0, clips.Length)];
        }
    }
}
