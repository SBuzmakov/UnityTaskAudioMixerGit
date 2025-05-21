using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class SliderVolumeChanger : MonoBehaviour
    {
        private const float VolumeMultiplier = 20f;

        [SerializeField] private AudioMixerGroup _audioMixerGroup;
        [SerializeField] private Slider _volumeSlider;

        private void OnEnable()
        {
            _volumeSlider.onValueChanged.AddListener(ChangeVolume);
        }

        private void OnDisable()
        {
            _volumeSlider.onValueChanged.RemoveListener(ChangeVolume);
        }

        private void ChangeVolume(float value)
        {
            _audioMixerGroup.audioMixer.SetFloat(_audioMixerGroup.name, Mathf.Log10(value) * VolumeMultiplier);
        }
    }
}