using System;
using System.Collections.Generic;
using UnityEngine;


public class SimpleButton : VRButton
{

    [SerializeField]
    GameObject src;

    protected override void OnClick(AudioSource aud)
    {
        base.OnClick(aud);

        Instantiate(src);
    }
}

