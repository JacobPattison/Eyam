using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour
{
    void Update()
    {
        float triggerRight = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
        if (triggerRight > 0.9f)
        {
            TreatmentKit.Grabbed = true;
        }
        if (triggerRight < 0.1f)
        {
            TreatmentKit.Grabbed = false;
        }
    }
}
