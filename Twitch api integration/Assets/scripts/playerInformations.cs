using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class playerInformations : MonoBehaviour
{

    public TMP_InputField oAuthInputF�eld;
    public TMP_Text oAuthText;
    public string oAuthString;
    public string channelNameString;
    public GameObject buttons;
    public GameObject informations;
    public TMP_Text channelNameText;
    void Start()
    {
        oAuthString = PlayerPrefs.GetString("oAuth");

    //   oAuthInputF�eld.contentType = TMP_InputField.ContentType.Password;
    }


    public void contentTypeButton()
    {
        /*if (oAuthInputF�eld.contentType == TMP_InputField.ContentType.Password)
        {
            oAuthInputF�eld.contentType = TMP_InputField.ContentType.Standard;
        }

        else if (oAuthInputF�eld.contentType == TMP_InputField.ContentType.Standard)
        {
            oAuthInputF�eld.contentType = TMP_InputField.ContentType.Password;
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