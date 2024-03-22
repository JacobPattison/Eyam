using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKitPlacer : MonoBehaviour
{
    public bool IsPlaced = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Treatment Kit" && IsPlaced == false)
        {
            GameManager.PatientsHealed++;
            IsPlaced = true;
            other.gameObject.transform.position = transform.position;
        }
    }
}
