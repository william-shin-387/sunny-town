﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// A PauseMenuScript is responsible for handling the interaction with the 
/// pause menu buttons.
/// </summary>
public class PauseMenuScript : MonoBehaviour
{
	public GameObject PauseMenu;
	public GameObject PausePanel;
    public GameObject PauseMenuPrefab;
    public Button PauseButton;
	public GameObject SettingsMenuPrefab;
    
    public void OpenPauseMenu()
    {
        Time.timeScale = 0f;
        Debug.Log("pause menu opened");
		PausePanel.gameObject.SetActive(true);
		PauseMenuPrefab.gameObject.SetActive(true);
		PauseMenu.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
		SettingsMenuPrefab.gameObject.SetActive(false);
    }

    public void ClosePauseMenu()
    {
		PausePanel.gameObject.SetActive(false);
		PauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("pause menu closed");
        PauseMenuPrefab.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
    }
    
    public void NavigateToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    /// <summary>
    /// Switches the actively displayed panel from the pause menu to the settings panel.
    /// </summary>
	public void OpenSettings() 
	{
		PauseMenu.gameObject.SetActive(false);
		SettingsMenuPrefab.gameObject.SetActive(true);
	}

    /// <summary>
    /// Switches the actively displayed panel from settings panel to the the pause menu.
    /// </summary>
	public void CloseSettings()
	{
		Debug.Log("Close settings");
		SettingsMenuPrefab.gameObject.SetActive(false);
		PauseMenu.gameObject.SetActive(true);
	}

}
