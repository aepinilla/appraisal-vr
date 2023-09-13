using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DirectionDepressing : MonoBehaviour
{
    private ParticleSystem ps;
    public bool moduleEnabled = true;

    public Slider SliderDirectionX;
    public Slider SliderDirectionY;
    public Slider SliderDirectionZ;

    void Start()
    {
        SliderDirectionZ.value = (float)2.5;

        SliderDirectionX.maxValue = 4;
        SliderDirectionX.minValue = -4;

        SliderDirectionY.maxValue = 4;
        SliderDirectionY.minValue = -4;
    
        SliderDirectionZ.maxValue = 4;
        SliderDirectionZ.minValue = -4;

        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var forceOverLifetime = ps.forceOverLifetime;
        forceOverLifetime.enabled = moduleEnabled;

        forceOverLifetime.x = SliderDirectionX.value;
        forceOverLifetime.y = SliderDirectionY.value;
        forceOverLifetime.z = SliderDirectionZ.value;

    }
}