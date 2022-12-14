using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClips_Soundtrack
{
    NONE,
    SONG_1,
    SONG_2,
}

public enum AudioClips_SFX
{
    NONE,
    AUTO,
    WALK,
    PUNCH,
    BULLET,
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;
    public AudioSource audioSourceEFFctRef;

    public AudioClip[] audioClipsSoundtrack;
    public AudioClip[] audioClipsVFX;

    public float SoundtrackVolume = 0.3f;

    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    public void SetAudioClipSoundtrack(AudioClips_Soundtrack audioClips_Soundtrack)
    {
        audioSource.Stop();
        audioSource.PlayDelayed(0.3f);
        audioSource.PlayOneShot(audioClipsSoundtrack[(int)audioClips_Soundtrack], SoundtrackVolume);

    }
}
