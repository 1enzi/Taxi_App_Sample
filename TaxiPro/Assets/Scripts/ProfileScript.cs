using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProfileScript : MonoBehaviour
{

    public Text NameField;
    public Text SurnameField;
    public Text PatronymicField;

    public Text NameText;
    public Text SurnameText;
    public Text PatronymicText;

    public Sprite Panda;
    public Sprite Birds;
    public Sprite Stars;
    public Sprite Ball;

    public GameObject IconSet;

    public GameObject UserIcon;

    private void Start()
    {
            IconSet.SetActive(false);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("Avatar") == 1)
        {
            UserIcon.GetComponent<Image>().sprite = Panda;
        }

        else if (PlayerPrefs.GetInt("Avatar") == 2)
        {
            UserIcon.GetComponent<Image>().sprite = Birds;
        }

        else if (PlayerPrefs.GetInt("Avatar") == 3)
        {
            UserIcon.GetComponent<Image>().sprite = Stars;
        }

        else if (PlayerPrefs.GetInt("Avatar") == 4)
        {
            UserIcon.GetComponent<Image>().sprite = Ball;
        }

    }

    public void SetName()
    {
        NameText.GetComponent<Text>().text = NameField.GetComponent<Text>().text;
    }

    public void SetSurname()
    {
        SurnameText.GetComponent<Text>().text = SurnameField.GetComponent<Text>().text;
    }

    public void SetPatronymic()
    {
        PatronymicText.GetComponent<Text>().text = PatronymicField.GetComponent<Text>().text;
    }

    public void SetPanda()
    {
        PlayerPrefs.SetInt("Avatar", 1);
    }

    public void SetBirds()
    {
        PlayerPrefs.SetInt("Avatar", 2);
    }

    public void SetStars()
    {
        PlayerPrefs.SetInt("Avatar", 3);
    }

    public void SetBall()
    {
        PlayerPrefs.SetInt("Avatar", 4);
    }
}
