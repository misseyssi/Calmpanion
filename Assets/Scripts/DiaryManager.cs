using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;


public class DiaryManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField noteInput;
    [SerializeField]
    private GameObject entryButtonOriginal;
    [SerializeField]
    private GameObject entryDisplayPanel;
    [SerializeField]
    private TMP_Text entryDisplayText;
    [SerializeField]
    private TMP_Text noMemoriesYetText;

    private string fileBeingDisplayed;
    private string savePath;

    private List<DiaryEntry> diaryEntries = new List<DiaryEntry>();
    private List<GameObject> instantiatedEntryButtons = new List<GameObject>();

    private void Start()
    {
        DetermineSavePath();
        Clear();
    }

    private void DetermineSavePath()
    {
#if UNITY_EDITOR
        savePath = Application.dataPath + "/SaveFiles/";
#else
        savePath = Application.persistentDataPath + "/SaveFiles/";
#endif

        if(!Directory.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }
    }

    public void Clear()
    {
        noteInput.text = string.Empty;
    }

    public void Save()
    {
        //save here
        StreamWriter writer = new StreamWriter(savePath + "Note-" + System.DateTime.Now.ToString("yyyyMMdd-HHmmssfff") + ".txt");
        writer.WriteLine(System.DateTime.Now.ToString());
        writer.Write(noteInput.text);
        writer.Close();

        Clear();
    }

    public void LoadMemories()
    {
        string[] files = Directory.GetFiles(savePath, "*.txt");

        noMemoriesYetText.gameObject.SetActive(files.Length <= 0);

        diaryEntries.Clear();
        for(int i = 0; i < files.Length; i++)
        {
            StreamReader reader = new StreamReader(files[i]);
            DiaryEntry entry = new DiaryEntry();
            entry.datetime = reader.ReadLine();
            entry.note = reader.ReadToEnd();
            entry.filepath = files[i];
            reader.Close();

            diaryEntries.Add(entry);
        }
        diaryEntries.Reverse();

        PopulateDiaryEntryButtons();
    }

    private void PopulateDiaryEntryButtons()
    {
        //delete instantiated buttons first
        for(int i = instantiatedEntryButtons.Count - 1; i >= 0; i--)
        {
            Destroy(instantiatedEntryButtons[i]);

        }
        instantiatedEntryButtons.Clear();

        //populate
        for(int i = 0; i<diaryEntries.Count; i++)
        {
            GameObject entryButtonCopy = Instantiate(entryButtonOriginal, entryButtonOriginal.transform.parent);
            string note = diaryEntries[i].note;
            string filepath = diaryEntries[i].filepath;
            entryButtonCopy.GetComponent<Button>().onClick.AddListener(() =>
            {
                DisplayEntry(note, filepath);

            });

            entryButtonCopy.GetComponentInChildren<TMP_Text>().text = diaryEntries[i].datetime;
            entryButtonCopy.SetActive(true);
            instantiatedEntryButtons.Add(entryButtonCopy);
        }
    }

    public void DeleteEntry()
    {
        File.Delete(fileBeingDisplayed);
        LoadMemories();
        entryDisplayPanel.SetActive(false);
    }

    public void DisplayEntry(string entryNote, string filepath)
    {
        fileBeingDisplayed = filepath;
        entryDisplayPanel.SetActive(true);
        entryDisplayText.text = entryNote;
    }

    public struct DiaryEntry
    {
        public string datetime;
        public string note;
        public string filepath;
    }
}
