using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    Light light;
    float initLightIntensity;
    public float maxLightDifference;
    public float changePerTick;
    // Start is called before the first frame update
    void Start()
    {
        light = gameObject.GetComponent<Light>();
        initLightIntensity = light.intensity;

    }

    // Update is called once per frame
    void Update()
    {
        System.Random random = new System.Random();
        print("Double: " + random.NextDouble());
        float increment = (float)random.NextDouble() * (changePerTick - (-changePerTick)) + -changePerTick;
        light.intensity += increment;

        print("Changed by: " + increment);

        if(light.intensity > initLightIntensity + maxLightDifference)
        {
            print("Too high");
            light.intensity = initLightIntensity + maxLightDifference;
        }else if(light.intensity < -initLightIntensity - maxLightDifference)
        {
            print("Too low");
            light.intensity = -initLightIntensity - maxLightDifference;
        }
    }
}
