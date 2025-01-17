
using UnityEngine;

namespace HyperionStation
{

    public class DotHskDoorBeep : MonoBehaviour
    {

        public AudioSource audioSource;
        public AudioClip beepSound;

        void OnTriggerEnter(Collider other)
        {
            if (Common.CollideWithPlayer(other))
            {
                if ((audioSource != null) && (beepSound != null))
                {
                    audioSource.clip = beepSound;
                    audioSource.time = 0;
                    audioSource.Play();
                }
            }

            if (Common.CollideWithEnemy(other))
            {
                if ((audioSource != null) && (beepSound != null))
                {
                    audioSource.clip = beepSound;
                    audioSource.time = 0;
                    audioSource.Play();
                }
            }
        }

    }

}