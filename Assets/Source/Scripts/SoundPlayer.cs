using UnityEngine;
using UnityEngine.UI;

namespace Source.Scripts
{
    public class SoundPlayer : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Button _button;

        private void OnEnable()
        {
            _button.onClick.AddListener(OnPlayButtonClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnPlayButtonClick);
        }
        
        private void OnPlayButtonClick()
        {
            _audioSource.Play();
        }
    }
}
