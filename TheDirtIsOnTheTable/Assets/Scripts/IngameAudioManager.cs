using UnityEngine;

public class IngameAudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource sfxSource = default;
    [SerializeField]
    private AudioSource ambienceSource = default;
    [SerializeField]
    private AudioClip music = default;
    private static IngameAudioManager _instance;

    void Awake()
    {
        _instance = this;
        if (music)
        {
            ambienceSource.loop = true;
            ambienceSource.clip = music;
            ambienceSource.Play();
        }
    }

    public static void PlaySFX(AudioClip audioClip)
    {
        _instance.sfxSource.PlayOneShot(audioClip);
    }
    public static void SetAmbience(AudioClip audioClip)
    {
        _instance.ambienceSource.Stop();
        _instance.ambienceSource.clip = audioClip;
        _instance.ambienceSource.Play();
    }

}