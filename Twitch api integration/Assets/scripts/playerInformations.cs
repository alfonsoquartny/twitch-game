using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class playerInformations : MonoBehaviour
{

    public TMP_InputField oAuthInputFýeld;
    public TMP_Text oAuthText;
    public string oAuthString;
    public string channelNameString;
    public GameObject buttons;
    public GameObject informations;
    public TMP_Text channelNameText;
    void Start()
    {
        oAuthString = PlayerPrefs.GetString("oAuth");

    //   oAuthInputFýeld.contentType = TMP_InputField.ContentType.Password;
    }


    public void contentTypeButton()
    {
        /*if (oAuthInputFýeld.contentType == TMP_InputField.ContentType.Password)
        {
            oAuthInputFýeld.contentType = TMP_InputField.ContentType.Standard;
        }

        else if (oAuthInputFýeld.contentType == TMP_InputField.ContentType.Standard)
        {
            oAuthInputFýeld.contentType = TMP_InputField.ContentType.Password;
        }
        */
    }


    public void playerprefsSave()
    {
        oAuthString = oAuthText.text;
        channelNameString = channelNameText.text;
        PlayerPrefs.SetString("channel",channelNameString);
        PlayerPrefs.SetString("oAuth", oAuthString);
        PlayerPrefs.Save();
    }

    public void continueButton()
    {
       playerprefsSave();
        buttons.SetActive(true);
        informations.SetActive(false);
    }


}