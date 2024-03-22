using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text LeaderboardText;
    public static List<string> players = new List<string>();

    public static Leaderboard Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void UpdateLeaderboard()
    {
        for(int player = 0; player < 10; player++)
        {
            string[] record = players[player].Split('|');
            LeaderboardText.text = record[0] + ": " + record[1];
        }
    }
}
