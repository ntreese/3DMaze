/*
 *****************************************************************************
* Modified the code to toggle various features in the UI menu. Original implementation cited below
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

public class CanvasFuncs : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider contTurn;
    public GameObject menuSlider;
    public GameObject sliderText;

    

    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            contTurn.enabled = true;
            menuSlider.SetActive(false);
            sliderText.SetActive(false);
        }
        else if (index == 1)
        {
            snapTurn.enabled = true;
            contTurn.enabled = false;
            menuSlider.SetActive(true);
            sliderText.SetActive(true);
        }
    }

}
