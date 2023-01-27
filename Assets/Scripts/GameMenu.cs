using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{
    public GameObject gameMenu;
    public InputActionProperty showButton;

    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            gameMenu.SetActive(!gameMenu.activeSelf);

        }

    }

    
}
