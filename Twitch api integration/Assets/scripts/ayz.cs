using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ayz : MonoBehaviour
{
    public TMP_Text hosgeldinText;
    void Start()
    {
        hosgeldinText.text ="Ho�geldin" +PlayerPrefs.GetString("channel")+", Ba�layal�m.";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
