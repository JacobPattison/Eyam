using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour
{
    public static bool IsGrabbing;
    void Update()
    {
        float triggerRight = OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger);
        if (triggerRight > 0.9f && TreatmentKit.Triggered == true && TreatmentKit.Placed == false)
        {
            IsGrabbing = true;
        }
        if (triggerRight < 0.1f)
        {
            IsGrabbing = false;
        }
    }
}