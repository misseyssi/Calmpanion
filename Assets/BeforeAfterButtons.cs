using UnityEngine;
using UnityEngine.UI;

public class MoodButton : MonoBehaviour
{
    private Text moodText; 

    private void Start()
    {
       
        moodText = GetComponent<Text>();

        Button beforeButton = GameObject.Find("BeforeButton").GetComponent<Button>();
        Button afterButton = GameObject.Find("AfterButton").GetComponent<Button>();
        Button exitButton = GameObject.Find("ExitButton").GetComponent<Button>();

        beforeButton.onClick.AddListener(RecordMoodBefore);
        afterButton.onClick.AddListener(RecordMoodAfter);
        exitButton.onClick.AddListener(ExitMoodTracker);
    }

    private void RecordMoodBefore()
    {
        moodText.text = "Mood Before: User's mood before using the app.";

    }

    private void RecordMoodAfter()
    {
        moodText.text = "Mood After: User's mood after using the app.";

    }

    private void ExitMoodTracker()
    {
 
        moodText.text = string.Empty; // Clear the mood text
        Debug.Log("Exiting Mood Tracker");
    }
}

