using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DirectionExciting : MonoBehaviour
{
    private ParticleSystem ps;
    public bool moduleEnabled = true;

    public Slider SliderDirectionX;
    public Slider SliderDirectionY;
    public Slider SliderDirectionZ;

    public float DirectionY;


    void Start()
    {
        SliderDirectionY.value = 5;

        SliderDirectionX.maxValue = 5;
        SliderDirectionX.minValue = -5;

        SliderDirectionY.maxValue = 5;
        SliderDirectionY.minValue = -5;

        SliderDirectionZ.maxValue = 5;
        SliderDirectionZ.minValue = -5;

        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var forceOverLifetime = ps.forceOverLifetime;
        forceOverLifetime.enabled = moduleEnabled;

        forceOverLifetime.x = SliderDirectionX.value;
        forceOverLifetime.y = SliderDirectionY.value;
        forceOverLifetime.z = SliderDirectionZ.value;

        DirectionY = SliderDirectionY.value;
    }
}