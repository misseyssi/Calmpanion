using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using TMPro;

public class MoodHistory : MonoBehaviour
{
    [System.Serializable]
    public class MoodData
    {
        public List<MoodEntry> entries = new List<MoodEntry>();
    }

    [System.Serializable]
    public class MoodEntry
    {
        public string mood;
        public DateTime timestamp;
    }

    protected MoodData moodDataBefore;
    protected MoodData moodDataAfter;

   [SerializeField] private TMP_Text historyTextBefore;
   [SerializeField] private TMP_Text historyTextAfter; 

    protected void Awake()
    {
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
        TMP_Text historyText = (tab == "Before") ? historyTextBefore : historyTextAfter;

        if (historyText != null)
        {
            historyText.text = "Mood History (" + tab + "):\n";
            foreach (MoodEntry entry in (tab == "Before") ? moodDataBefore.entries : moodDataAfter.entries)
            {
                historyText.text += entry.mood + " - " + entry.timestamp.ToString("yyyy-MM-dd HH:mm:ss") + "\n";
            }
        }
    }

    protected void SaveMoodToHistory(string mood, string tab)
    {
        MoodData moodData = (tab == "Before") ? moodDataBefore : moodDataAfter;
        moodData.entries.Add(new MoodEntry { mood = mood, timestamp = DateTime.Now });

        string key = gameObject.name + "MoodHistory" + tab;
        string jsonHistory = JsonUtility.ToJson(moodData);
        PlayerPrefs.SetString(key, jsonHistory);
        PlayerPrefs.Save();

        Debug.Log("Saved Mood History (" + tab + "): " + jsonHistory);
        Debug.Log("Mood Selected (" + tab + "): " + mood);

        UpdateUI(tab); 
    }
}

