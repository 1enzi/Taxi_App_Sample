using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPage : MonoBehaviour
{

    public Sprite BackgroundOne;
    public Sprite BackgroundTwo;
    public Sprite DownBackgroundOne;
    public Sprite DownBackgroundTwo;
    public GameObject TopBack;
    public GameObject DownBack;

    public GameObject DriverButton;
    public GameObject PassengerButton;
    public GameObject Sample;

    private void Start()
    {

        ColorBlock Colors = Sample.GetComponent<Button>().colors;
        ColorBlock Colors2 = Sample.GetComponent<Button>().colors;

        if (PlayerPrefs.GetInt("DarkThemeOn") == 1)
        {
            Colors.normalColor = Color.white;
            Colors.highlightedColor = Color.white;
            Colors.pressedColor = Color.gray;
            Colors.selectedColor = Color.white;
            Colors.disabledColor = Color.gray;

            TopBack.GetComponent<Image>().sprite = BackgroundTwo;
            DownBack.GetComponent<Image>().sprite = DownBackgroundTwo;
            DriverButton.GetComponent<Button>().colors = Colors;
            PassengerButton.GetComponent<Button>().colors = Colors;
        }

        else
        {
            TopBack.GetComponent<Image>().sprite = BackgroundOne;
            DownBack.GetComponent<Image>().sprite = DownBackgroundOne;
            DriverButton.GetComponent<Button>().colors = Colors2;
            PassengerButton.GetComponent<Button>().colors = Colors2;
        }
    }
}
