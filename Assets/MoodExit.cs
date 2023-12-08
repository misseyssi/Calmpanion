using UnityEngine;
using UnityEngine.UI;

public class AfterMoodTracker : MoodHistory // It extends the MoodHistory class. This means that it inherits all the properties and methods from the MoodHistory class.
{
    // Declared for each mood in the main menu of the app.  The [SerializeField] attribute allows these private fields to be exposed in the Unity editor for easy assignment of button references.
    [SerializeField] private Button happyButton;
    [SerializeField] private Button calmButton;
    [SerializeField] private Button sadButton;
    [SerializeField] private Button angryButton;
    [SerializeField] private Button loveButton;
    [SerializeField] private Button joyfulButton;
    [SerializeField] private Button doneButton;

    private void Start() // It is called when the script is initialized.
    {
        // It sets up event listeners for each button using the onClick.AddListener method. When a button is clicked, it triggers a lambda expression that calls the TrackMood method with the corresponding mood and the "After" tab.
        happyButton.onClick.AddListener(() => TrackMood("Happy", "After"));
        calmButton.onClick.AddListener(() => TrackMood("Calm", "After"));
        sadButton.onClick.AddListener(() => TrackMood("Sad", "After"));
        angryButton.onClick.AddListener(() => TrackMood("Angry", "After"));
        loveButton.onClick.AddListener(() => TrackMood("Love", "After"));
        joyfulButton.onClick.AddListener(() => TrackMood("Joyful", "After"));
        doneButton.onClick.AddListener(ExitApplication);
    }

    private void TrackMood(string mood, string tab) // It is called when a button is clicked. 
    {
        SaveMoodToHistory(mood, tab); // It calls the SaveMoodToHistory method from the MoodHistory class, passing in the mood and tab as arguments.
    }

    private void ExitApplication() 
    {
        Debug.Log("Exiting the application."); // // Indicating that the application is being exited.

        // For Android
#if UNITY_ANDROID // This preprocessor directive checks if the current platform is Android. The code inside this block will only be executed if the application is running on an Android device.
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true); 
#endif
    }
}

