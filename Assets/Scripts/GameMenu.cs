/*
 *****************************************************************************
* Modified the code to toggle the in-game flashlight when the menu is toggled.
* 
* Citation of external code
* 
* Title: How to Make a VR Game in Unity 2022 - Part 7 - User Interface
* Author: Valem Tutorials
* Date: 2022
* Availability: https://www.youtube.com/watch?v=yhB921bDLYA&t=665s&ab_channel=ValemTutorials
****************************************************************************
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class GameMenu : MonoBehaviour
{
    public GameObject gameMenu;
    public GameObject flashLight;
    public InputActionProperty showButton;

    public Transform Head;
    public float SpawnDistance = 2;

    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            gameMenu.SetActive(!gameMenu.activeSelf);
            //flashLight.SetActive(!gameMenu.activeSelf);

            gameMenu.transform.position = Head.position + new Vector3(Head.forward.x, 0, Head.forward.z).normalized * SpawnDistance;
        }

        gameMenu.transform.LookAt(new Vector3(Head.position.x, gameMenu.transform.position.y, Head.position.z));
        gameMenu.transform.forward *= -1;
    }
}
