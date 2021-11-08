using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverScript : MonoBehaviour
{
    public GameObject ChatObject;
    bool ChatIsActive;


    public Text MessageInput;
    public Transform ChatContent;
    public GameObject TextField;
    public Text TextFieldText;
    public GameObject TextFieldReverse;
    public Text TextFieldTextReverse;
    float Y = 3.5F;
    int MessagesCounter = 0;

    public GameObject Background;
    Vector4 Color;
    public GameObject ButtonBackground;

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

        TextFieldReverse.SetActive(false);
        TextField.SetActive(false);
        ChatObject.SetActive(false);
        ChatIsActive = false;
    }

    void Update()
    {

    }

    public void ChatButtonClick()
    {
        if (ChatIsActive == false)
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

    public void InputText()
    {
        if (MessagesCounter < 3)
        {
            TextField.SetActive(true);
            TextFieldText.GetComponent<Text>().text = MessageInput.GetComponent<Text>().text;
            GameObject newTextField = Instantiate(TextField, ChatContent, false);
            newTextField.transform.position = new Vector3(0.6F, Y, 0);
            Y = Y - 1.5F;
            MessagesCounter++;

            TextFieldReverse.SetActive(true);
            TextFieldTextReverse.GetComponent<Text>().text = "Пассажиру направлен запрос на звонок.";
            GameObject newTextField2 = Instantiate(TextFieldReverse, ChatContent, false);
            newTextField2.transform.position = new Vector3(-1.4F, Y, 0);
            Y = Y - 1.5F;
        }
    }

    public void Clear()
    {
        MessageInput.GetComponent<Text>().text = null;
    }
}
