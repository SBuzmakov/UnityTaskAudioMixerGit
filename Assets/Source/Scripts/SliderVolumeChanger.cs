using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class SliderVolumeChanger : MonoBehaviour
    {
        private const float VolumeMultiplier = 20f;

        [SerializeField] private AudioMixer _audioMixer;
        [SerializeField] private Slider _volumeSlider;
        [SerializeField] private string _audioMixerGroupName;

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
            _audioMixer.SetFloat(_audioMixerGroupName, Mathf.Log10(value) * VolumeMultiplier);
        }
    }
}