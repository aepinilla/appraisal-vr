using UnityEngine;
using UnityEngine.UI;

public class EstimatedEmotion2 : MonoBehaviour
{
    private HsbColor hsbColor;
    private Speed speed;
    private Direction direction;
    private HeartbeatSpeed heartbeatSpeed;

    float arousal;
    float arousalHue;
    float arousalSaturation;
    float arousalBrightness;
    float arousalSpeed;
    float arousalDirection;

    float valence;
    float valenceSaturation;
    float valenceBrightness;

    public Button excitedButton;
    public Button relaxedButton;
    public Button boredButton;
    public Button stressedButton;

    void Start()
    {
        //hsbColor = GetComponent<HsbColor>();
        //speed = GetComponent<Speed>();
        //direction = GetComponent<Direction>();
        //heartbeatSpeed = GetComponent<HeartbeatSpeed>();

        //Button btnExcited = excitedButton.GetComponent<Button>();
        //btnExcited.onClick.AddListener(toggleExcited);

        //Button btnRelaxed = relaxedButton.GetComponent<Button>();
        //btnRelaxed.onClick.AddListener(toggleRelaxed);

        //Button btnBored = boredButton.GetComponent<Button>();
        //btnBored.onClick.AddListener(toggleBored);

        //Button btnStressed = stressedButton.GetComponent<Button>();
        //btnStressed.onClick.AddListener(toggleStressed);
    }

    void Update()
    {
        //arousalHue = 8 * Mathf.Pow((float)(hsbColor.Hue - 0.5), 2) - 1;
        //arousalSaturation = 2 * (hsbColor.Saturation) - 1;
        //arousalBrightness = 2 * (hsbColor.Brightness) - 1;
        //arousalSpeed = (speed.SpeedVal);
        //arousalDirection = (direction.DirectionY) / 20;


        //arousal = (arousalHue + arousalSaturation + arousalBrightness + arousalSpeed + arousalDirection) / 5;

        //valenceSaturation = 2 * (hsbColor.Saturation) - 1;
        //valenceBrightness = 2 * (hsbColor.Brightness) - 1;

        //valence = (valenceSaturation + valenceBrightness) / 2;

        //Debug.Log("Arousal is " + arousal);
        //Debug.Log("Valence is " + valence);

    }

    //void toggleExcited()
    //{
    //    hsbColor.SliderHue.value = (float)0.5;
    //    hsbColor.SliderSaturation.value = 1;
    //    hsbColor.SliderBrightness.value = 1;
    //    speed.SliderSpeed.value = 10;
    //    direction.SliderDirectionY.value = 20;
    //    heartbeatSpeed.SliderHeartbeat.value = 2;
    //}

    //void toggleRelaxed()
    //{
    //    hsbColor.SliderHue.value = (float)0.5;
    //    hsbColor.SliderSaturation.value = 0;
    //    hsbColor.SliderBrightness.value = (float)0.5;
    //    speed.SliderSpeed.value = 1;
    //    direction.SliderDirectionY.value = 1;
    //    heartbeatSpeed.SliderHeartbeat.value = 1;
    //}

    //void toggleBored()
    //{
    //    hsbColor.SliderHue.value = (float)0.5;
    //    hsbColor.SliderSaturation.value = 0;
    //    hsbColor.SliderBrightness.value = 0;
    //    speed.SliderSpeed.value = 1;
    //    direction.SliderDirectionY.value = -1;
    //    heartbeatSpeed.SliderHeartbeat.value = 0;
    //}

    //void toggleStressed()
    //{
    //    hsbColor.SliderHue.value = 1;
    //    hsbColor.SliderSaturation.value = 1;
    //    hsbColor.SliderBrightness.value = 1;
    //    speed.SliderSpeed.value = 10;
    //    direction.SliderDirectionY.value = 20;
    //    heartbeatSpeed.SliderHeartbeat.value = 2;
    //}
}