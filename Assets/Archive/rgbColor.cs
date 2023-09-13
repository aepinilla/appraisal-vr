using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rgbColor : MonoBehaviour
{

    private ParticleSystem ps;
    public float hSliderValueR = 0.0F;
    public float hSliderValueG = 0.0F;
    public float hSliderValueB = 0.0F;
    public float hSliderValueA = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        var delta = Input.GetAxis("Mouse ScrollWheel");

        if (Input.GetKey(KeyCode.R) == true)
        {
            hSliderValueR = hSliderValueR - (delta / 10);
            main.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);

            if (hSliderValueR < 0) { hSliderValueR = 0; }
            if (hSliderValueR > 1) { hSliderValueR = 1; }
        }

        if (Input.GetKey(KeyCode.G) == true)
        {
            hSliderValueG = hSliderValueG - (delta / 10);
            main.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);

            if (hSliderValueG < 0) { hSliderValueG = 0; }
            if (hSliderValueG > 1) { hSliderValueG = 1; }
        }

        if (Input.GetKey(KeyCode.B) == true)
        {
            hSliderValueB = hSliderValueB - (delta / 10);
            main.startColor = new Color(hSliderValueR, hSliderValueG, hSliderValueB, hSliderValueA);

            if (hSliderValueB < 0) { hSliderValueB = 0; }
            if (hSliderValueB > 1) { hSliderValueB = 1; }
        }

    }

}
