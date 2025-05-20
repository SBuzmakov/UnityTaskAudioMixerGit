using UnityEngine;

namespace Source.Scripts
{
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;

        public void Play()
        {
            _audioSource.Play();
        }
    }
}
