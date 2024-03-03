using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    [Header("Sound")]
    public AudioClip ClickSound;
    //public AudioMixerGroup MixerGroup;
    [Range(0.0f, 1.0f)]
    public float volume = 0.3f;

    private Button _button { get { return GetComponent<Button>(); } }
    private AudioSource _source { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        var aud = gameObject.AddComponent<AudioSource>();
        aud.hideFlags = HideFlags.HideInInspector;
        _source.playOnAwake = false;
        //_source.outputAudioMixerGroup = MixerGroup;
        _source.volume = volume;

        _button.onClick.AddListener(() =>
        {
            if (_source.isActiveAndEnabled)
            {
                _source.PlayOneShot(ClickSound);
            }
        });
    }

    

}