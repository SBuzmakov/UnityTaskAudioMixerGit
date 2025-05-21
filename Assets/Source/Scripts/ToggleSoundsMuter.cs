using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class ToggleSoundsMuter : MonoBehaviour
    {
        private const float MaxVolume = 0f;
        private const float MinVolume = -80.0f;
        private const float VolumeMultiplier = 20f;
        
        [SerializeField] private Toggle _muteToggle;
        [SerializeField] private AudioMixerGroup _audioMixerGroup;

        private void OnEnable()
        {
            _muteToggle.onValueChanged.AddListener(MuteSounds);
        }

        private void OnDisable()
        {
            _muteToggle.onValueChanged.RemoveListener(MuteSounds);
        }

        private void MuteSounds(bool soundsDisabled)
        {
            if (soundsDisabled)
            {
                _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(MaxVolume) * VolumeMultiplier);
            }
            else
            {
                _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(MinVolume) * VolumeMultiplier);
            }
        }
    }
}