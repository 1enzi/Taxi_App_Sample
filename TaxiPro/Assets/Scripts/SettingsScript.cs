using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{

    public GameObject SettingsHeader;
    public GameObject SettingsBackground;
    Vector4 SettingsColor;

    void Start()
    {
        
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("DarkMode") == 1)
        {
            SettingsColor = new Vector4(217 / 255.0f, 217 / 255.0f, 217 / 255.0f, 1);
        }
        else
        {
            SettingsColor = new Vector4(1, 1, 1, 1);
        }

        SettingsHeader.GetComponent<Image>().color = SettingsColor;
        SettingsBackground.GetComponent<Image>().color = SettingsColor;
    }

    public void SetLightMode()
    {
        PlayerPrefs.SetInt("DarkMode", 0);
    }

    public void SetDarkMode()
    {
        PlayerPrefs.SetInt("DarkMode", 1);
    }

    public void SetDarkTheme()
    {
        PlayerPrefs.SetInt("DarkThemeOn", 1);
    }
    
    public void SetLightTheme()
    {
        PlayerPrefs.SetInt("DarkThemeOn", 0);
    }
}
