using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class VRButton : MonoBehaviour
{
    [SerializeField]
    AudioClip clickAudio;

    protected virtual void OnClick(AudioSource aud)
    {
        if (aud && clickAudio)
        {
            aud.PlayOneShot(clickAudio, 7f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("finger"))
        {
            AudioSource aud = other.gameObject.GetComponent<AudioSource>();
            OnClick(aud);
        }
    }
}

