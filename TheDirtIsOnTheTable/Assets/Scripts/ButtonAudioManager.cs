using UnityEngine;

public class ButtonAudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource sfxSource = default;
    [SerializeField]
    private static ButtonAudioManager _instance;

    public static void PlaySFX(AudioClip audioClip)
    {
        _instance.sfxSource.PlayOneShot(audioClip);
    }

}