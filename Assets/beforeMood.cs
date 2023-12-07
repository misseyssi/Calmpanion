using UnityEngine;
using UnityEngine.UI;

public class BeforeMoodTracker : MoodHistory
{
    [SerializeField] private Button happyButton;
    [SerializeField] private Button calmButton;
    [SerializeField] private Button sadButton;
    [SerializeField] private Button angryButton;
    [SerializeField] private Button loveButton;
    [SerializeField] private Button joyfulButton;

    private void Start()
    {
        happyButton.onClick.AddListener(() => TrackMood("Happy", "Before"));
        calmButton.onClick.AddListener(() => TrackMood("Calm", "Before"));
        sadButton.onClick.AddListener(() => TrackMood("Sad", "Before"));
        angryButton.onClick.AddListener(() => TrackMood("Angry", "Before"));
        loveButton.onClick.AddListener(() => TrackMood("Love", "Before"));
        joyfulButton.onClick.AddListener(() => TrackMood("Joyful", "Before"));
    }

    private void TrackMood(string mood, string tab)
    {
        SaveMoodToHistory(mood, tab);
    }
}
