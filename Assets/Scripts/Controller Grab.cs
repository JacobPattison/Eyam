using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            if(TreatmentKit.Grabbed)
            {
                TreatmentKit.Grabbed = false;
            }
        }
    }
}
