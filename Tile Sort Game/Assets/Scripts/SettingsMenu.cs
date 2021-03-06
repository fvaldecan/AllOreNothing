﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start()
    {
        // Get resolution options and update to current one
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;
    
        for (int i = 0; i < resolutions.Length; i++){
            
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width 
                && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }
        
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution (int resolutionIndex) {
        // Current resolution
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume (float volume) {
        //Changes in volume (still in progress..)
        Debug.Log(volume);
    }
    public void SetFullScreen (bool isFullScreen){
        // Change in and out of fullscreen
        Screen.fullScreen = isFullScreen;
    }    
    
}
