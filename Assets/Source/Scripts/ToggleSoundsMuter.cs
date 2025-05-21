using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class ToggleSoundsMuter : MonoBehaviour
    {
        [SerializeField] private Toggle _muteToggle;
        [SerializeField] private AudioListener _audioListener;
        
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
            _audioListener.enabled = !soundsDisabled;
        }
    }
}