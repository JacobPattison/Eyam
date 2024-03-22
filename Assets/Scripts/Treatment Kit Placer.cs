using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKitPlacer : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text DebugText;

    [SerializeField] bool IsPlaced = false;
    [SerializeField] GameObject PlacementTransform;

    private void Start()
    {
        PlacementTransform = new GameObject();
        PlacementTransform.transform.position = transform.position;
        PlacementTransform.transform.rotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.tag == "Treatment Kit" && IsPlaced == false)
        {
            IsPlaced = true;
            other.gameObject.transform.position = PlacementTransform.transform.position;
            DebugText.text += "\r\nPlacer Triggered";
        }
        */
    }
}
