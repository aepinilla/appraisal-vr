using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class HeartbeatSpeedLaser : MonoBehaviour
{
    AudioSource audioSource;
    public Slider SliderHeartbeat;
    public float heartSpeed;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SliderHeartbeat.maxValue = 2;
        SliderHeartbeat.minValue = 1;

        SliderHeartbeat.value = 2;
        audioSource.pitch = 2;
    }

    void Update()
    {
        audioSource.pitch = SliderHeartbeat.value;
        heartSpeed = SliderHeartbeat.value;
    }
}