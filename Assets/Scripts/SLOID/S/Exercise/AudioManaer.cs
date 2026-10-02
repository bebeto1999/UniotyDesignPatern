using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip endWaveSound;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayEndWaveSound()
    {
        audioSource.PlayOneShot(endWaveSound);
    }

}