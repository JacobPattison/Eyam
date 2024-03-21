using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKit : MonoBehaviour
{
    GameObject UpdateTransform;
    Transform Controller;
    static public bool Grabbed;

    void Start()
    {
        UpdateTransform = new GameObject();
        UpdateTransform.transform.position = transform.position;
        UpdateTransform.transform.rotation = transform.rotation;
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
            transform.position = UpdateTransform.transform.position;
            transform.rotation = UpdateTransform.transform.rotation;
        }
        UpdateTransform.transform.position = transform.position;
        UpdateTransform.transform.rotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GameController")
        {
            Grabbed = true;
            Controller = other.gameObject.transform;
        }
    }
}
