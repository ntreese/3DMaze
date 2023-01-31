using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footStep;
    public AudioSource footStep2;
    public Transform XROrigin;
    public float stepLength;
    private Vector3 startPoint;
    private Vector3 currentPos;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        startPoint = XROrigin.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = XROrigin.position;

        if ((startPoint - currentPos).magnitude > stepLength)
        {
            startPoint = currentPos;
            if(count == 1)
            {
                footStep.Play();
                count = 2;
            }
            else
            {
                footStep2.Play();
                count = 1;
            }
            
        }
    }
}
