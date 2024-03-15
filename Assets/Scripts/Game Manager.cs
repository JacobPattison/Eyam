using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PatientPrefab;
    public GameObject UsernameInputPrefab;

    public static bool IsPlaying = false;
    public static int PatientsHealed;
    public float CurrentTime;
    public int PatientAmount;

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
            }
        }
    }

    public void StartGame()
    {
        IsPlaying = true;
        PatientsHealed = 0;
        CurrentTime = 0.0f;
        SpawnPatients();
    }

    public void EndGame()
    {
        IsPlaying = false;
        Instantiate(UsernameInputPrefab, new Vector3(2.10f, 0.41f, -0.04f), Quaternion.identity);
    }

    public void SpawnPatients()
    {
        Instantiate(PatientPrefab, new Vector3(-0.73f, 0f, -1.41f), Quaternion.identity);
        Instantiate(PatientPrefab, new Vector3(0.23f, 0, -1.41f), Quaternion.identity);
    }
}
