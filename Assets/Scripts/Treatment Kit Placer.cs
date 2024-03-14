using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKitPlacer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Treatment Kit")
        {
            GameManager.PatientsHealed++;
        }
    }
}
