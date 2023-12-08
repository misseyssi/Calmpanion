using UnityEngine;
using UnityEngine.UI;

public class BeforeMoodTracker : MoodHistory // It extends the MoodHistory class. This means that it inherits all the properties and methods from the MoodHistory class.
{
    // Declared for each mood in the main menu of the app.  The [SerializeField] attribute allows these private fields to be exposed in the Unity editor for easy assignment of button references.
    [SerializeField] private Button happyButton;
    [SerializeField] private Button calmButton;
    [SerializeField] private Button sadButton;
    [SerializeField] private Button angryButton;
    [SerializeField] private Button loveButton;
    [SerializeField] private Button joyfulButton;

    private void Start() // It is called when the script is initialized. 
    {
        // It sets up event listeners for each button using the onClick.AddListener method. When a button is clicked, it triggers a lambda expression that calls the TrackMood method with the corresponding mood and the "Before" tab.
        happyButton.onClick.AddListener(() => TrackMood("Happy", "Before"));
        calmButton.onClick.AddListener(() => TrackMood("Calm", "Before"));
        sadButton.onClick.AddListener(() => TrackMood("Sad", "Before"));
        angryButton.onClick.AddListener(() => TrackMood("Angry", "Before"));
        loveButton.onClick.AddListener(() => TrackMood("Love", "Before"));
        joyfulButton.onClick.AddListener(() => TrackMood("Joyful", "Before"));
    }

    private void TrackMood(string mood, string tab) // It is called when a button is clicked. 
    {
        SaveMoodToHistory(mood, tab); // It calls the SaveMoodToHistory method from the MoodHistory class, passing in the mood and tab as arguments.
    }
}
