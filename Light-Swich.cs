using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Light spotLight;

    void Start()
    {
        // Assuming your light is attached to the same GameObject as this script.
        spotLight = GetComponent<Light>();

        // If the light is not directly attached to this GameObject, you can find it by name or tag.
        // Example: spotLight = GameObject.Find("Spotlight").GetComponent<Light>();
        // Example: spotLight = GameObject.FindGameObjectWithTag("Spotlight").GetComponent<Light>();
    }

    void Update()
    {
        // Check for button press (you can customize the input based on your needs).
        if (Input.GetButtonDown("Fire1"))
        {
            // Toggle the light state.
            ToggleLightState();
        }
    }

    void ToggleLightState()
    {
        // Toggle the light's enabled state.
        spotLight.enabled = !spotLight.enabled;
    }
}
