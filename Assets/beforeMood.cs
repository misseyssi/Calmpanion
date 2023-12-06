using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoodSelector : MonoBehaviour
{
    public TextMeshProUGUI moodDisplay; // UI text to display the selected mood
    private string selectedMood;

    // Call this method when a mood button is clicked
    public void OnMoodButtonClick(string mood)
    {
        selectedMood = mood;
        UpdateMoodDisplay();
        SaveMoodToHistory();
    }

    private void UpdateMoodDisplay()
    {
        if (moodDisplay != null)
        {
            moodDisplay.text = "Selected Mood: " + selectedMood;
        }
    }

    private void SaveMoodToHistory()
    {
        // Save the selected mood to history or before tab
        PlayerPrefs.SetString("HistoryMood", selectedMood);
        PlayerPrefs.Save();
    }
}
