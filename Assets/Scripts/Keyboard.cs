using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    public TMPro.TMP_Text NameText;
    public string Text = "";

    public void KeyPressed (string input)
    {
        char character = input[0];
        if (character == '@') // Backspace
        {
            Text = Text.Substring (0, Text.Length - 1);
        }
        else if (character == '#') // Space
        {
            Text = Text + ' ';
        }
        else if (character == '&')
        {
            Leaderboard.players.Add(Text + ": " + "10:00");
        }
        else
        {
            Text = Text + character;
        }

        NameText.text = Text;
    }

}
