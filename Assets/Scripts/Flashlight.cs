using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    public Light lightsource;
    public AudioSource flashlightSound;
    public InputActionProperty showButton;


    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            lightsource.enabled = !lightsource.enabled;
            flashlightSound.Play();
        }
    }
}
