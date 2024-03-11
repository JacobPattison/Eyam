using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatmentKitSpawner : MonoBehaviour
{
    [SerializeField] GameObject TreatmentKitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTreatmentKit(float vertialOffset)
    {
        float xPos = transform.position.x;
        float yPos = transform.position.y + vertialOffset;
        float zPos = transform.position.z;
        Instantiate(TreatmentKitPrefab, new Vector3(xPos, yPos, zPos), Quaternion.identity);
    }
}
