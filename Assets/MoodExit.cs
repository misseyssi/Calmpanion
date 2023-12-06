using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MoodPopup : MonoBehaviour
{
    [SerializeField] private GameObject moodPopup;
    [SerializeField] private Button happyButton, calmButton, sadButton, angryButton, loveButton, joyfulButton;
    [SerializeField] private Button doneButton;

    private string selectedMood;

    private void Start()
    {
        happyButton.onClick.AddListener(() => SetSelectedMood("Happy"));
        calmButton.onClick.AddListener(() => SetSelectedMood("Calm"));
        sadButton.onClick.AddListener(() => SetSelectedMood("Sad"));
        angryButton.onClick.AddListener(() => SetSelectedMood("Angry"));
        loveButton.onClick.AddListener(() => SetSelectedMood("Love"));
        joyfulButton.onClick.AddListener(() => SetSelectedMood("Joyful"));

        doneButton.onClick.AddListener(ExitWithMood);
    }

    public void ShowMoodPopup()
    {
        moodPopup.SetActive(true);
    }

    private void SetSelectedMood(string mood)
    {
        selectedMood = mood;
    }

    private void ExitWithMood()
    {
        if (!string.IsNullOrEmpty(selectedMood))
        {

            Debug.Log("Selected Mood: " + selectedMood);
        }

        // Close the app
        Application.Quit();
    }
}
