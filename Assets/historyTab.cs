using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HistoryTab : MonoBehaviour
{
    public TextMeshProUGUI historyDisplay; // UI text to display the history of moods

    private void Start()
    {
        DisplayHistory();
    }

    private void DisplayHistory()
    {

        string historyMood = PlayerPrefs.GetString("HistoryMood", "No Mood Selected");

        // Display the mood in the UI
        if (historyDisplay != null)
        {
            historyDisplay.text = "Mood History: " + historyMood;
        }
    }
}

