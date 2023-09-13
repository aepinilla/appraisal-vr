using UnityEngine;

public class ActivateHeartbeat : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

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

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            audioSource.Stop();
        }
    }
}