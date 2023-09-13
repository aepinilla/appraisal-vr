using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    private ParticleSystem ps;
    public Slider SliderSpeed;
    public float SpeedVal;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        SliderSpeed.value = 2;
        SliderSpeed.maxValue = 10;
        SliderSpeed.minValue = 0;

        var velocityOverLifetime = ps.velocityOverLifetime;
        velocityOverLifetime.enabled = true;
        velocityOverLifetime.space = ParticleSystemSimulationSpace.World;

        AnimationCurve curve = new AnimationCurve();
        curve.AddKey(0.0f, 0.0f);
        curve.AddKey(1.0f, 1.0f);

        ParticleSystem.MinMaxCurve minMaxCurve = new ParticleSystem.MinMaxCurve(20.0f, curve);

        velocityOverLifetime.speedModifier = minMaxCurve;
    }

    void Update()
    {
        var velocityOverLifetime = ps.velocityOverLifetime;
        velocityOverLifetime.speedModifierMultiplier = SliderSpeed.value;
        SpeedVal = SliderSpeed.value;
    }
}