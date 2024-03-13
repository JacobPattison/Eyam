using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKit : MonoBehaviour
{
    GameObject StartTransform;
    Transform Controller;
    static public bool Grabbed;

    void Start()
    {
        StartTransform = new GameObject();
        StartTransform.transform.position = transform.position;
        StartTransform.transform.rotation = transform.rotation;
    }

    void Update()
    {
        if (Grabbed)
        {
            transform.position = Controller.transform.position;
            transform.rotation = Controller.transform.rotation;
        }
        else
        {
            transform.position = StartTransform.transform.position;
            transform.rotation = StartTransform.transform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Grabbed = true;
        Controller = other.gameObject.transform;
    }
}
