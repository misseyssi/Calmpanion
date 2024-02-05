using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AppLockManager : MonoBehaviour
{
    public GameObject registerPinPanel;
    public InputField registerPinInput;
    public GameObject confirmPinPanel;
    public InputField confirmPinInput;


    public GameObject signinPinPanel;
    public InputField signinPinInput;
    public GameObject incorrectPin;

    public GameObject resetPinBtn;

    bool hasPin = false;
    string pin = "";
    int incorrectPinCount =0;

    private const int MAX_INCORRECT_COUNT_BEFORE_SHOWING_RESETPIN = 3;
    private const int PIN_LENGTH = 4;

    void Start()
    {
        hasPin = false;
        if(PlayerPrefs.HasKey("USER_PIN"))
        {
            pin = PlayerPrefs.GetString("USER_PIN");
            if(!string.IsNullOrEmpty(pin))
            {
                if (pin.Length == PIN_LENGTH)
                    hasPin = true;
            }
        }

        registerPinPanel.SetActive(!hasPin);
        signinPinPanel.SetActive(hasPin);
        resetPinBtn.SetActive(false);
        incorrectPinCount = 0;
    }

    public void RegisterPin()
    {
        if(!string.IsNullOrEmpty(registerPinInput.text))
        {
            if(registerPinInput.text.Length == PIN_LENGTH)
            {
                pin = registerPinInput.text;
                confirmPinPanel.SetActive(true);
                registerPinPanel.SetActive(false);
                confirmPinInput.text = string.Empty;
                incorrectPin.SetActive(false);
            }
        }
    }

    public void ConfirmPin()
    {
        if(confirmPinInput.text == pin)
        {
            PlayerPrefs.SetString("USER_PIN", pin);
            SceneManager.LoadScene("Menu 1");
        }
        else
        {
            incorrectPin.SetActive(true);
            confirmPinInput.text = string.Empty;
        }
    }

    public void SignIn()
    {
        if(signinPinInput.text == pin)
        {
            //correct 
            SceneManager.LoadScene("Menu 1");
        }
        else
        {
            signinPinInput.text = string.Empty;
            incorrectPin.SetActive(true);
            incorrectPinCount++;

            if (incorrectPinCount >= MAX_INCORRECT_COUNT_BEFORE_SHOWING_RESETPIN)
                resetPinBtn.SetActive(true);
        }
    }

    public void ResetPin()
    {
        incorrectPin.SetActive(false);
        registerPinPanel.SetActive(true);
        confirmPinPanel.SetActive(false);
        signinPinPanel.SetActive(false);
        pin = "";
    }
}
