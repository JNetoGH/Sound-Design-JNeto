using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

public class Ellen_Sounds : MonoBehaviour
{

    AudioSource walksource;
    public AudioClip[] walk;
    public AudioMixerGroup walkMixer;

    AudioSource runsource;
    public AudioClip[] run;
    public AudioMixerGroup runsmixer;
    
    AudioSource combosGrunts;
    public AudioClip[] comboGrunts;
    public AudioMixerGroup comboGruntsMixer;
    
    AudioSource combo1source;
    public AudioClip[] combo1;
    public AudioMixerGroup combo1mixer;

    AudioSource combo2source;
    public AudioClip[] combo2;
    public AudioMixerGroup combo2mixer;

    AudioSource combo3source;
    public AudioClip[] combo3;
    public AudioMixerGroup combo3mixer;

    AudioSource combo4source;
    public AudioClip[] combo4;
    public AudioMixerGroup combo4mixer;

    AudioSource deathsource;
    public AudioClip[] death;
    public AudioMixerGroup deathmixer;

    AudioSource hitsource;
    public AudioClip[] hit;
    public AudioMixerGroup hitmixer;
    
    AudioSource hitMoansource;
    public AudioClip[] hitMoans;
    public AudioMixerGroup hitMoanMixer;

    AudioSource jumpsource;
    public AudioClip[] jump;
    public AudioMixerGroup jumpmixer;

    AudioSource spawnsource;
    public AudioClip[] spawn;
    public AudioMixerGroup spawnmixer;

    // Start is called before the first frame update
    void Start()
    {
        walksource = gameObject.AddComponent<AudioSource>();
        walksource.outputAudioMixerGroup = walkMixer;

        runsource = gameObject.AddComponent<AudioSource>();
        runsource.outputAudioMixerGroup = runsmixer;
        
        combo1source = gameObject.AddComponent<AudioSource>();
        combo1source.outputAudioMixerGroup = combo1mixer;

        combo2source = gameObject.AddComponent<AudioSource>();
        combo2source.outputAudioMixerGroup = combo2mixer;

        combo3source = gameObject.AddComponent<AudioSource>();
        combo3source.outputAudioMixerGroup = combo3mixer;

        combo4source = gameObject.AddComponent<AudioSource>();
        combo4source.outputAudioMixerGroup = combo4mixer;

        deathsource = gameObject.AddComponent<AudioSource>();   
        deathsource.outputAudioMixerGroup = deathmixer;

        hitsource = gameObject.AddComponent<AudioSource>();
        hitsource.outputAudioMixerGroup = hitmixer;

        jumpsource = gameObject.AddComponent<AudioSource>();
        jumpsource.outputAudioMixerGroup = jumpmixer;

        spawnsource = gameObject.AddComponent<AudioSource>();
        spawnsource.outputAudioMixerGroup = spawnmixer;
    }

    public void Footsteps()
    {
        walksource.clip = walk[Random.Range(0, walk.Length)];
        walksource.pitch = Random.Range(0.0f, 1.2f);
        walksource.volume = Random.Range(0.9f, 1.1f);
        walksource.PlayOneShot(walksource.clip);
    }
    public void Combo1()
    {
        combo1source.clip = combo1[Random.Range(0, combo1.Length)];
        combo1source.pitch = Random.Range(0.8f, 1.2f);
        combo1source.volume = Random.Range(0.9f, 1.1f);
        combo1source.PlayOneShot(combo1source.clip);
    }

    public void Combo2()
    {
        combo2source.clip = combo2[Random.Range(0, combo2.Length)];
        combo2source.pitch = Random.Range(0.8f, 1.2f);
        combo2source.volume = Random.Range(0.9f, 1.1f);
        combo2source.PlayOneShot(combo2source.clip);
    }

    public void Combo3()
    {
        combo3source.clip = combo3[Random.Range(0, combo3.Length)];
        combo3source.pitch = Random.Range(0.8f, 1.2f);
        combo3source.volume = Random.Range(0.9f, 1.1f);
        combo3source.PlayOneShot(combo3source.clip);
    }

    public void Combo4()
    {
        combo4source.clip = combo4[Random.Range(0, combo4.Length)];
        combo4source.PlayOneShot(combo4source.clip);
    }

    public void Death()
    {
        deathsource.clip = death[Random.Range(0, death.Length)];
        deathsource.pitch = Random.Range(0.8f, 1.2f);
        deathsource.volume = Random.Range(0.9f, 1.1f);
        deathsource.PlayOneShot(deathsource.clip);
    }

    public void Hit()
    {
        hitsource.clip = hit[Random.Range(0, hit.Length)];
        hitsource.pitch = Random.Range(0.8f, 1.2f);
        hitsource.volume = Random.Range(0.9f, 1.1f);
        hitsource.PlayOneShot(hitsource.clip);
    }

    public void Jump()
    {
        /*
        jumpsource.clip = jump[Random.Range(0, jump.Length)];
        jumpsource.pitch = Random.Range(0.8f, 1.2f);
        jumpsource.volume = Random.Range(0.9f, 1.1f);
        jumpsource.PlayOneShot(jumpsource.clip);
        */
    }

    public void Run()
    {
        /*
        runsource.clip = run[Random.Range(0, run.Length)];
        runsource.pitch = Random.Range(0.8f, 1.2f);
        runsource.volume = Random.Range(0.9f, 1.1f);
        runsource.PlayOneShot(runsource.clip);
        */
    }

    public void Spawn()
    {
        spawnsource.clip = spawn[Random.Range(0, spawn.Length)];
        spawnsource.pitch = Random.Range(0.8f, 1.2f);
        spawnsource.volume = Random.Range(0.9f, 1.1f);
        spawnsource.PlayOneShot(spawnsource.clip);   
    }
    
}
