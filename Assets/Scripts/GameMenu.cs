using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
/*Code sourced from Valem Tutorials on YouTube*/

public class GameMenu : MonoBehaviour
{
    public GameObject gameMenu;
    public GameObject flashLight;
    public InputActionProperty showButton;

    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            gameMenu.SetActive(!gameMenu.activeSelf);
            flashLight.SetActive(!gameMenu.activeSelf);
        }
    }
}
