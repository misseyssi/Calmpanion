using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;
using System.Text;

public class MoodHistory : MonoBehaviour
{
    [System.Serializable]
    public class MoodData // This class represents the mood history data and contains a list of MoodEntry objects.
    {
        public List<MoodEntry> entries = new List<MoodEntry>();
    }

    [System.Serializable]
    public class MoodEntry // This class represents a single entry in the mood history and contains the mood string and the timestamp of when it was recorded.
    {
        public string mood;
        public DateTime timestamp;
    }
    // These are references to the TextMeshPro (TMP) Text components in the Unity scene that will display the mood history for the "Before" and "After" tabs, respectively.
    [SerializeField] private TMP_Text historyTextBefore;
    [SerializeField] private TMP_Text historyTextAfter;

    // The moodDataBefore and moodDataAfter variables are declared to store the mood history data for the "Before" and "After" tabs, respectively.
    protected MoodData moodDataBefore;
    protected MoodData moodDataAfter;

    protected void Awake() // It is called when the script is initialized and loads the mood history data for both tabs and updates the UI.
    {
        // These lines load the mood history data for the "Before" and "After" tabs using the LoadMoodHistory method and assign them to the moodDataBefore and moodDataAfter variables, respectively.
        moodDataBefore = LoadMoodHistory("Before");
        moodDataAfter = LoadMoodHistory("After");
        UpdateUI("Before");
        UpdateUI("After");
    }

    protected MoodData LoadMoodHistory(string tab)
    {
        string key = gameObject.name + "MoodHistory" + tab;
        string jsonHistory = PlayerPrefs.GetString(key);
        Debug.Log("Loaded Mood History (" + tab + "): " + jsonHistory);
        return !string.IsNullOrEmpty(jsonHistory) ? JsonUtility.FromJson<MoodData>(jsonHistory) : new MoodData();
    }

    protected void UpdateUI(string tab)
    {
        TMP_Text historyText = (tab == "Before") ? historyTextBefore : historyTextAfter; // This line assigns the appropriate TMP_Text component based on the specified tab ("Before" or "After") to the historyText variable using a ternary operator.

        if (historyText != null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Mood History (" + tab + "):");

            foreach (MoodEntry entry in (tab == "Before") ? moodDataBefore.entries : moodDataAfter.entries)
            {
                // Format timestamp using "MM-dd-yyyy h:mm tt" format
                string formattedTimestamp = entry.timestamp.ToString("MM-dd-yyyy h:mm tt");

                // Append the mood and timestamp to the StringBuilder
                stringBuilder.AppendLine(entry.mood + " - " + formattedTimestamp);
            }

            // Set the text of the TMP_Text component
            historyText.text = stringBuilder.ToString();
        }
    }

    public void SaveMoodToHistory(string mood, string tab) // This method saves the selected mood to the respective mood history tab, along with the current timestamp.
    {
        MoodData moodData = (tab == "Before") ? moodDataBefore : moodDataAfter;

        DateTime currentTime = DateTime.Now;
        Debug.Log("Current System Time (" + tab + "): " + currentTime.ToString("MM-dd-yyyy h:mm tt"));

        moodData.entries.Add(new MoodEntry { mood = mood, timestamp = currentTime }); // This line creates a new MoodEntry object with the selected mood and the current timestamp and adds it to the entries list of the respective MoodData object.

        string key = gameObject.name + "MoodHistory" + tab;
        string jsonHistory = JsonUtility.ToJson(moodData);
        PlayerPrefs.SetString(key, jsonHistory);
        PlayerPrefs.Save();

        // Log information for debugging
        Debug.Log("Saved Mood History (" + tab + "): " + jsonHistory);
        Debug.Log("Mood Selected (" + tab + "): " + mood);

        UpdateUI(tab); // This method updates the UI text components with the mood history data for the specified tab.
    }
}

