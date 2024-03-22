using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text NameText;
    [SerializeField] string Text = "";

    public void KeyPressed (string input)
    {
        char character = input[0];
        if (character == '@') // Backspace
        {
            Text = Text.Substring (0, Text.Length - 1);
        }
        else if (character == '&') // Enter
        {
            Leaderboard.players.Add(Text + ": " + GameManager.CurrentTime.ToString("0:00"));
            // Need to update leaderboard here
        }
        else // Character
        {
            Text = Text + character;
        }
        NameText.text = Text;
    }

}
