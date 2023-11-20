using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonControl : MonoBehaviour
{
    public GameObject theText;

    public void ClearText()
    {
        theText.GetComponent<TMP_InputField>().text = "";
    }
}