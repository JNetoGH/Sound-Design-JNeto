using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Chompies_Sounds : MonoBehaviour
{
    AudioSource attacksource;
    public AudioClip[] attack;
    public AudioMixerGroup attackmixer;

    AudioSource hitsource;
    public AudioClip[] hit;
    public AudioMixerGroup hitmixer;

    AudioSource idlesource;
    public AudioClip[] idle;
    public AudioMixerGroup idlemixer;

    AudioSource runsource;
    public AudioClip[] run;
    public AudioMixerGroup runmixer;

    AudioSource walksource;
    public AudioClip[] walk;
    public AudioMixerGroup walkmixer;

    // Start is called before the first frame update
    void Start()
    {
        float min = 11;
        float max = 13;
        
        attacksource = gameObject.AddComponent<AudioSource>();
        attacksource.outputAudioMixerGroup = attackmixer;
        attacksource.minDistance = min;
        attacksource.maxDistance = max;

        hitsource = gameObject.AddComponent<AudioSource>();
        hitsource.outputAudioMixerGroup = hitmixer;
        hitsource.minDistance = min;
        hitsource.maxDistance = max;
        
        idlesource = gameObject.AddComponent<AudioSource>();
        idlesource.outputAudioMixerGroup = idlemixer;
        idlesource.minDistance = min;
        idlesource.maxDistance = max;
        idlesource.rolloffMode = AudioRolloffMode.Linear;
        
        runsource = gameObject.AddComponent<AudioSource>();
        runsource.outputAudioMixerGroup = runmixer;
        runsource.minDistance = min;
        runsource.maxDistance = max;
        
        walksource = gameObject.AddComponent<AudioSource>();
        walksource.outputAudioMixerGroup = walkmixer;
        walksource.minDistance = min;
        walksource.maxDistance = max;
    }

    public void Attack()
    {
        attacksource.clip = attack[Random.Range(0, attack.Length)];
        attacksource.pitch = Random.Range(0.8f, 1.2f);
        attacksource.volume = Random.Range(0.9f, 1.1f);
        attacksource.PlayOneShot(attacksource.clip);
    }

    public void Hit()
    {
        hitsource.clip = hit[Random.Range(0, hit.Length)];
        hitsource.pitch = Random.Range(0.8f, 1.2f);
        hitsource.volume = Random.Range(0.9f, 1.1f);
        hitsource.PlayOneShot(hitsource.clip);
    }

    public void Idle()
    {
        idlesource.clip = idle[Random.Range(0, idle.Length)];
        idlesource.pitch = Random.Range(0.8f, 1.2f);
        idlesource.volume = Random.Range(0.9f, 1.1f);
        idlesource.PlayOneShot(idlesource.clip);
    }

    public void Run()
    {
        runsource.clip = run[Random.Range(0, run.Length)];
        runsource.pitch = Random.Range(0.8f, 1.2f);
        runsource.volume = Random.Range(0.9f, 1.1f);
        runsource.PlayOneShot(runsource.clip);
    }

    public void Walk()
    {
        walksource.clip = walk[Random.Range(0, walk.Length)];
        walksource.pitch = Random.Range(0.8f, 1.2f);
        walksource.volume = Random.Range(0.9f, 1.1f);
        walksource.PlayOneShot(walksource.clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
