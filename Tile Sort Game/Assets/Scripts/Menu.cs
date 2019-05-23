using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Menu : MonoBehaviour
{
    public GameObject mainMenuHolder;
	public GameObject optionsMenuHolder;
    public GameObject rulesMenuHolder;   
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions; 

    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("volume", volume);
    }
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit() 
    {
		Application.Quit ();
	}
    public void Rules()
    {
        mainMenuHolder.SetActive(false);
        rulesMenuHolder.SetActive(true);
    }
	public void OptionsMenu() {
		mainMenuHolder.SetActive (false);
		optionsMenuHolder.SetActive (true);
	}

	public void MainMenu() {
		mainMenuHolder.SetActive (true);
		optionsMenuHolder.SetActive (false);
        rulesMenuHolder.SetActive(false);
	}
    
    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
    

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
            if (resolutions[i].width == Screen.width 
                && resolutions[i].height == Screen.height){
                currentResolutionIndex = i;
            }
        }
        
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution (int resolutionIndex) 
    {
        // Current resolution
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    
}
