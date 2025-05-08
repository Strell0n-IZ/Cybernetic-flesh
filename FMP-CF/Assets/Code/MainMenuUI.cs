using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas SettingsScreen;
    public Canvas SettingsSound;
    public Canvas Settings;

    public Canvas Credits;

    void Start()
    {
        MainMenu.enabled = true;
        Settings.enabled = false;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = false;
        Credits.enabled = false;
    }

    public void OnNewgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnSettings()
    {
        MainMenu.enabled = false;
        Settings.enabled = true;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = false;
        Credits.enabled = false;
    }

    public void OnCredit()
    {
        MainMenu.enabled = false;
        Settings.enabled = false;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = false;
        Credits.enabled = true;
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnBackToMain()
    {
        MainMenu.enabled = true;
        Settings.enabled = false;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = false;
        Credits.enabled = false;
    }

    public void OnBackToSettings()
    {
        MainMenu.enabled = false;
        Settings.enabled = true;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = false;
        Credits.enabled = false;
    }


    public void OnScreen()
    {
        MainMenu.enabled = false;
        Settings.enabled = false;
        SettingsScreen.enabled = true;
        SettingsSound.enabled = false;
        Credits.enabled = false;
    }
    public void OnSound()
    {
        MainMenu.enabled = false;
        Settings.enabled = false;
        SettingsScreen.enabled = false;
        SettingsSound.enabled = true;
        Credits.enabled = false;
    }
}
