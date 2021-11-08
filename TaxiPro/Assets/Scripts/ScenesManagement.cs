using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManagement : MonoBehaviour
{
    public void Passenger()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("AppMode", 1);
    }


    public void Driver()
    {
        SceneManager.LoadScene("DriverScene");
        PlayerPrefs.SetInt("AppMode", 2);
    }

    public void GoBack()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void GoBackSettingsButton()
    {
        if (PlayerPrefs.GetInt("AppMode") == 2)
        {
            SceneManager.LoadScene("DriverScene");
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Profile()
    {
        SceneManager.LoadScene("Profile");
    }
}
