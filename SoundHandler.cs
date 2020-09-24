using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

public class SoundHandler : MonoBehaviour
{

    public AudioSource backgroundMusicSource;
    public AudioSource sfxSource;

    public SFXManager sfxController;
    public MusicManager musicController;

    private EventsGroup listeners = new EventsGroup();

    // Start is called before the first frame update
    void Start()
    {
        listeners.Add(GameConstants.MusicVolumeChangeEvent, MusicVolumeChangeHandler);
        listeners.Add(GameConstants.SfxVolumeChangeEvents, SfxVolumeChangeHandler);
        listeners.StartListening();

        backgroundMusicSource.volume = GlobalStaticVariables.musicVolume;
        sfxSource.volume = GlobalStaticVariables.sfxVolume;
    }

    private void MusicVolumeChangeHandler()
    {
        backgroundMusicSource.volume = GlobalStaticVariables.musicVolume;
    }

    private void SfxVolumeChangeHandler()
    {
        sfxSource.volume = GlobalStaticVariables.sfxVolume;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
