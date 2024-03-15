using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public TMPro.TMP_Text LeaderboardText;
    public static List<string> players = new List<string>();

    public void UpdateLeaderboard()
    {
        for(int player = 0; player < 10; player++)
        {
            string[] record = players[player].Split('|');
            LeaderboardText.text = record[0] + ": " + record[1];
        }
    }
}
