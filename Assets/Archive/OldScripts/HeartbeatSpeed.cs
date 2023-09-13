using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class HeartbeatSpeed : MonoBehaviour
{
    AudioSource audioSource;
    public Slider SliderHeartbeat;
    public float heartSpeed;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.pitch = 1;

        SliderHeartbeat.maxValue = 2;
        SliderHeartbeat.minValue = 1;
    }

    void Update()
    {
        audioSource.pitch = SliderHeartbeat.value;
        heartSpeed = SliderHeartbeat.value - 1;
    }
}