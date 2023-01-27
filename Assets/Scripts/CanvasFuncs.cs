using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class CanvasFuncs : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider contTurn;

    public void SetTypeFromIndex(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            contTurn.enabled = true;
        }
        else if (index == 1)
        {
            snapTurn.enabled = true;
            contTurn.enabled = false;
        }
    }
}
