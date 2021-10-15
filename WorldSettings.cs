
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

public class WorldSettings : UdonSharpBehaviour
{
    public Slider lightIntensity;
    public Light[] lights;
    private float[] lightStartingIntensities;

    void Start()
    {
        lightStartingIntensities = new float[lights.Length]; // initializing lightStartingIntensities to length of lights array

        var index = 0;

        foreach(var light in lights)
        {
            lightStartingIntensities[index] = light.intensity;
            index += 1;
        }
    }

    public void OnLightSliderChange()
    {
        var index = 0;
        foreach(var light in lights)
        {
           
            light.intensity = lightStartingIntensities[index] * lightIntensity.value;
            index += 1;
        }
        //Debug.Log(lightIntensity.value);
    }

}
