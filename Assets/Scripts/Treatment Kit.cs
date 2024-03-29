using TMPro;
using UnityEngine;

public class TreatmentKit : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text DebugText;

    [SerializeField] GameObject UpdateTransform;
    [SerializeField] GameObject TreatmentKitPrefab;
    [SerializeField] Transform Controller;

    public static bool Triggered;
    public static bool Placed;

    void Start()
    {
        UpdateTransform = new GameObject();
        UpdateTransform.transform.position = transform.position;
        UpdateTransform.transform.rotation = transform.rotation;
        Placed = false;

        GameObject findDebugText;
        findDebugText = GameObject.FindGameObjectWithTag("Debug Text");
        foreach (Transform childTransform in findDebugText.transform)
        {
            TMP_Text w = childTransform.GetComponent<TMP_Text>();
            if (w != null)
            {
                DebugText = w;
                DebugText.text += "\r\nDebug Text Found";
            }
        }
    }

    void Update()
    {
        if (ControllerGrab.IsGrabbing && Triggered)
        {
            transform.position = Controller.transform.position;
            transform.rotation = Controller.transform.rotation;
        }
        else if (Placed == false)
        {
            transform.position = UpdateTransform.transform.position;
            transform.rotation = UpdateTransform.transform.rotation;
        }
        UpdateTransform.transform.position = transform.position;
        UpdateTransform.transform.rotation = transform.rotation;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "GameController")
        {
            Triggered = true;
            Controller = other.gameObject.transform;
        }
        if (other.tag == "Treatment Kit Placer")
        {
            ControllerGrab.IsGrabbing = false;
            Triggered = false;
            Placed = true;
            transform.position = other.gameObject.transform.position;
            transform.rotation = other.gameObject.transform.rotation;
            DebugText.text += "\r\nPlacer Triggered";
            Destroy(other.gameObject);
            // New Questionn
            Instantiate(TreatmentKitPrefab, new Vector3(0.3f, 0.7f, -2.5f), Quaternion.identity);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "GameController")
        {
            Triggered = false;
        }
    }
}
