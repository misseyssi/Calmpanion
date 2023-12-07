using UnityEngine;
using UnityEngine.UI;

public class AfterMoodTracker : MoodHistory
{
    [SerializeField] private Button happyButton;
    [SerializeField] private Button calmButton;
    [SerializeField] private Button sadButton;
    [SerializeField] private Button angryButton;
    [SerializeField] private Button loveButton;
    [SerializeField] private Button joyfulButton;
    [SerializeField] private Button doneButton;

    private void Start()
    {
        happyButton.onClick.AddListener(() => TrackMood("Happy", "After"));
        calmButton.onClick.AddListener(() => TrackMood("Calm", "After"));
        sadButton.onClick.AddListener(() => TrackMood("Sad", "After"));
        angryButton.onClick.AddListener(() => TrackMood("Angry", "After"));
        loveButton.onClick.AddListener(() => TrackMood("Love", "After"));
        joyfulButton.onClick.AddListener(() => TrackMood("Joyful", "After"));
        doneButton.onClick.AddListener(ExitApplication);
    }

    private void TrackMood(string mood, string tab)
    {
        SaveMoodToHistory(mood, tab);
    }

    private void ExitApplication()
    {
        Debug.Log("Exiting the application.");

        // For Android
#if UNITY_ANDROID
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
#endif
    }
}

