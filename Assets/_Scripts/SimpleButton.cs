using System;
using System.Collections.Generic;
using UnityEngine;


public class SimpleButton : VRButton
{
    protected override void OnClick(AudioSource aud)
    {
        base.OnClick(aud);
        Debug.Log("Hello World");
    }
}

