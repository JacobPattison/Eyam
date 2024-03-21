using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PatientPrefab;
    public GameObject UsernameInputPrefab;
    public GameObject TreatmentKitPrefab;

    public TMPro.TMP_Text CurrentTimeText;

    public static bool IsPlaying = false;
    public static int PatientsHealed;
    public static float CurrentTime;
    public int PatientAmount;

    public Vector3[] PatientSpawnPoints;

    private void Start()
    {
        PatientSpawnPoints = new Vector3[6];
        PatientSpawnPoints[0] = new Vector3(1.6f, 0.5f, -5.28800011f);
        PatientSpawnPoints[1] = new Vector3(-1.6f, 0.5f, -5.28800011f);
        PatientSpawnPoints[2] = new Vector3(1.6f, 0.5f, -6.84399986f);
        PatientSpawnPoints[3] = new Vector3(-1.6f, 0.5f, -6.84399986f);
        PatientSpawnPoints[4] = new Vector3(1.6f, 0.5f, -8.30500031f);
        PatientSpawnPoints[5] = new Vector3(-1.6f, 0.5f, -8.30500031f);
        PatientAmount = 6;
    }

    void Update()
    {
        if (IsPlaying)
        {
            if (PatientsHealed >= PatientAmount)
            {
                EndGame();
            }
            else
            {
                CurrentTime += Time.deltaTime;
                CurrentTimeText.text = "Time: " + CurrentTime.ToString("0:00");
            }
        }
    }

    public void StartGame()
    {
        IsPlaying = true;
        PatientsHealed = 0;
        CurrentTime = 0.0f;
        SpawnPatients();
        SpawnTreatmentKits(PatientAmount);
    }

    public void EndGame()
    {
        IsPlaying = false;
        Instantiate(UsernameInputPrefab, new Vector3(2.10f, 0.41f, -0.04f), Quaternion.identity);
    }

    public void SpawnPatients()
    {
        for (int patient = 0; patient < PatientAmount; patient++)
        {
            Instantiate(PatientPrefab, PatientSpawnPoints[patient], Quaternion.identity);
        }
    }

    public void SpawnTreatmentKits(int amount)
    {
        for (int treatmentKit = 0; treatmentKit < amount; treatmentKit++)
        {
            Instantiate(TreatmentKitPrefab, new Vector3(0.3f, 0.7f, -2.5f), Quaternion.identity);
        }
    }
}
