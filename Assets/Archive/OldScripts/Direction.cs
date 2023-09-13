using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Direction : MonoBehaviour
{
    private ParticleSystem ps;
    public bool moduleEnabled = true;

    public Slider SliderDirectionX;
    public Slider SliderDirectionY;
    public Slider SliderDirectionZ;

    public float DirectionY;
    

    void Start()
    {
        SliderDirectionX.maxValue = 20;
        SliderDirectionX.minValue = -20;

        SliderDirectionY.maxValue = 20;
        SliderDirectionY.minValue = -20;

        SliderDirectionZ.maxValue = 20;
        SliderDirectionZ.minValue = -20;

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