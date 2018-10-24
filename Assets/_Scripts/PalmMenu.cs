using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PalmMenu : MonoBehaviour
{
    protected float palmRotZ;

    [SerializeField]
    float maxPalmRotZ = 0;
    [SerializeField]
    float minPalmRotZ = 0;

    [SerializeField]
    GameObject myMenu;

    [SerializeField]
    Transform palmRotTrs;

    private void Start()
    {
        myMenu.SetActive(false);
    }

    void Update()
    {
        palmRotZ = palmRotTrs.rotation.z;
        myMenu.SetActive(palmRotZ < maxPalmRotZ && palmRotZ > minPalmRotZ);
        Debug.Log(palmRotZ);
    }
}
