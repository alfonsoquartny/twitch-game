using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class playerInformations : MonoBehaviour
{

    public TMP_InputField oAuth;
    void Start()
    {
        oAuth.contentType = TMP_InputField.ContentType.Password;
    }


    public void contentTypeButton()
    {
        if (oAuth.contentType == TMP_InputField.ContentType.Password)
        {
            oAuth.contentType = TMP_InputField.ContentType.Standard;
        }

        else if (oAuth.contentType == TMP_InputField.ContentType.Standard)
        {
            oAuth.contentType = TMP_InputField.ContentType.Password;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
