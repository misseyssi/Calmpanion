using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveLoad : MonoBehaviour
{
    public string theText;
    public GameObject ourNote;
    public GameObject placeHolder;

    void Start()
    {
        theText = PlayerPrefs.GetString("NoteContents");
        placeHolder.GetComponent<TMP_InputField>().text = theText;
    }

    public void SaveNote()
    {
        theText = ourNote.GetComponent<TMP_Text>().text;
        PlayerPrefs.SetString("NoteContents", theText);

    }

}
