using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{

    public GameObject ChatObject;
    public GameObject RateObject;
    bool ChatIsActive;
    bool RateIsActive;

    public Sprite[] Sprites;
    public GameObject RateImage;

    public Text MessageInput;
    public Transform ChatContent;
    public GameObject TextField;
    public Text TextFieldText;
    public GameObject TextFieldReverse;
    public Text TextFieldTextReverse;
    float Y = 3.5F;
    int MessagesCounter = 0;
    public GameObject ContentObject;
    public GameObject RateText;
    int StarRate = 1;

    public GameObject Background;
    Vector4 Color;
    public GameObject ButtonBackground;
    public GameObject RateButton;

    void Start()
    {
        if (PlayerPrefs.GetInt("DarkMode") == 1)
        {
            Color = new Vector4(193 / 255.0f, 193 / 255.0f, 193 / 255.0f, 1);
        }
        else
        {
            Color = new Vector4(1, 1, 1, 1);
        }

        Background.GetComponent<Image>().color = Color;
        ButtonBackground.GetComponent<Image>().color = Color;

        RateText.SetActive(false);
        TextFieldReverse.SetActive(false);
        TextField.SetActive(false);
        ChatObject.SetActive(false);
        RateObject.SetActive(false);
        RateIsActive = false;
        ChatIsActive = false;

        ColorBlock RateButtonColor = RateButton.GetComponent<Button>().colors;
        ColorBlock RateButtonColor2 = RateButton.GetComponent<Button>().colors;
    }

    /*void Update()
    {
        RateButton.GetComponent<Button>().colors = RateButtonColor;
    }*/

    public void ChatButtonClick() 
    {
        if (ChatIsActive == false && RateIsActive == false)
        {
            ChatObject.SetActive(true);
            ChatIsActive = true;
        }

        else if (ChatIsActive == true)
        {
            ChatObject.SetActive(false);
            ChatIsActive = false;
        }
    }

    public void RateButtonClick()
    {
        if (PlayerPrefs.GetInt("OrderIsActive") == 1)
        {
            RateButtonColor = new Vector4(217 / 255.0f, 217 / 255.0f, 217 / 255.0f, 1);
        }
        else
        {
            RateButtonColor = new Vector4(1, 1, 1, 1);
        }

        if (RateIsActive == false && ChatIsActive == false && (PlayerPrefs.GetInt("OrderIsActive") == 2))
        {
            RateObject.SetActive(true);
            RateIsActive = true;
        }

        else if (RateIsActive == true)
        {
            RateObject.SetActive(false);
            RateIsActive = false;
        }
    }

    public void InputText()
    {
        if (MessagesCounter < 3)
        {
            TextField.SetActive(true);
            TextFieldText.GetComponent<Text>().text = MessageInput.GetComponent<Text>().text;
            GameObject newTextField = Instantiate(TextField, ChatContent, false);
            newTextField.transform.position = new Vector3(8.5F, Y, 0);
            Y = Y - 1.5F;
            MessagesCounter++;

            TextFieldReverse.SetActive(true);
            TextFieldTextReverse.GetComponent<Text>().text = "Аббонент просит перезвонить ему.";
            GameObject newTextField2 = Instantiate(TextFieldReverse, ChatContent, false);
            newTextField2.transform.position = new Vector3(6.5F, Y, 0);
            Y = Y - 1.5F;
        }
    }

    public void Clear()
    {
        MessageInput.GetComponent<Text>().text = null;
    }

    public void RateOne()
    {
        RateImage.GetComponent<Image>().sprite = Sprites[0];
        StarRate = 1;
        RateText.GetComponent<Text>().text = "Нам жаль, что Вы остались недовольны :(";
    }

    public void RateTwo()
    {
        RateImage.GetComponent<Image>().sprite = Sprites[1];
        StarRate = 2;
        RateText.GetComponent<Text>().text = "Напишите, что Вам не понравилось!";
    }

    public void RateThree()
    {
        RateImage.GetComponent<Image>().sprite = Sprites[2];
        StarRate = 3;
        RateText.GetComponent<Text>().text = "Мы постараемся сделать Вашу следущую поездку комфортнее!";
    }

    public void RateFour()
    {
        RateImage.GetComponent<Image>().sprite = Sprites[3];
        StarRate = 4;
        RateText.GetComponent<Text>().text = "Что бы мы могли улучшить в нашем сервисе? :)";
    }

    public void RateFive()
    {
        RateImage.GetComponent<Image>().sprite = Sprites[4];
        StarRate = 5;
        RateText.GetComponent<Text>().text = "Спасибо за оценку, будем рады Вам снова! :)";

    }

    public void RateClick()
    {
        RateText.SetActive(true);
    }
}
