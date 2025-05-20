using UnityEngine;
using UnityEngine.Audio;

namespace Source.Scripts
{
    public class VolumeChanger : MonoBehaviour
    {
        private const float MinVolume = -80f;
        private const float MaxVolume = 0f;
        private const float VolumeMultiplier = 20f;
        private const string MasterVolume = "MasterVolume";
        private const string MusicVolume = "MusicVolume";
        private const string SfxVolume = "SFXVolume";
        
        [SerializeField] private AudioMixerGroup _audioMixerGroup;

        private bool _isSoundsEnabled = true;
        
        public void MuteSounds()
        {
            if (_isSoundsEnabled)
            {
                _audioMixerGroup.audioMixer.SetFloat(MasterVolume, Mathf.Log10(MinVolume) * VolumeMultiplier);
                _isSoundsEnabled = false;
            }
            else
            {
                _audioMixerGroup.audioMixer.SetFloat(MasterVolume, Mathf.Log10(MaxVolume) * VolumeMultiplier);
                _isSoundsEnabled = true;
            }
        }

        public void ChangeMusicVolume(float value)
        {
            _audioMixerGroup.audioMixer.SetFloat(MusicVolume, Mathf.Log10(value) * VolumeMultiplier);
        }
        
        public void ChangeSfxVolume(float value)
        {
            _audioMixerGroup.audioMixer.SetFloat(SfxVolume, Mathf.Log10(value) * VolumeMultiplier);
        }

        public void ChangeMasterVolume(float value)
        {
            _audioMixerGroup.audioMixer.SetFloat(MasterVolume, Mathf.Log10(value) * VolumeMultiplier);

        }
    }
}
