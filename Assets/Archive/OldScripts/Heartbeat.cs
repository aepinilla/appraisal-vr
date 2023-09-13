using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class Heartbeat : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (1.0f == OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger))
        {
            audioSource.pitch = 1;
        }

        else
        {
            audioSource.pitch = 2;
        }

    }
}
