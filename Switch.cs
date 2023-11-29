using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    private GameObject flashlightObject;
    private Light flashlight;
    private bool isFlashlightOn = true;

    void Start()
    {
        // Find the GameObject with the "FlashLight" tag.
        flashlightObject = GameObject.FindGameObjectWithTag("FlashLight");

        // Check if the GameObject has a Light component.
        if (flashlightObject != null)
        {
            flashlight = flashlightObject.GetComponent<Light>();
        }
        else
        {
            Debug.LogError("Flashlight GameObject not found or does not have a Light component.");
        }
    }

    void Update()
    {
        // Check for left mouse button press.
        if (Input.GetMouseButtonDown(0))
        {
            // Toggle the flashlight state.
            ToggleFlashlightState();
        }
    }

    void ToggleFlashlightState()
    {
        if (flashlight != null)
        {
            // Toggle the flashlight on/off by enabling/disabling the Light component.
            isFlashlightOn = !isFlashlightOn;
            flashlight.enabled = isFlashlightOn;
        }
    }
}
