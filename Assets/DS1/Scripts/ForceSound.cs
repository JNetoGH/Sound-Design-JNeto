using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSound : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        }
    }
}
