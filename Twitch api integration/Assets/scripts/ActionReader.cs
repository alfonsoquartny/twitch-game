using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System.IO;
public class ActionReader : MonoBehaviour
{
    public TMP_Text chat;


    public string path;
    public string membersPath;
    public List<string> membersLine;
    public StreamWriter sw;
    public List<string> membersKayit;

    public movement movement;

    public List<string> dataLines;
    public List<string> newPlayers;

    public Transform canvas;

    public string[] komutlar;
    private void Start()
    {

        path = Application.dataPath + "/playersData.txt";


        membersPath = Application.dataPath + "/members.txt";
        sw = new StreamWriter(membersPath);

        membersKayit = System.IO.File.ReadLines(membersPath).ToList();
        membersLine = System.IO.File.ReadLines(membersPath).ToList();

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("VERILER SILINDI");
        }


        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("saved members");
            sw.Close();

            membersLine = new List<string>(System.IO.File.ReadAllLines(membersPath));
        }
    }
    public void OnChatMessage(string pChatter, string pMessage)
    {
        if (pMessage.Contains("!kayit"))
        {
            if (PlayerPrefs.GetString(pChatter) == pChatter)
            {
                Debug.Log("Zaten Kat�ld�n!   "+pChatter);
            
            }
            else
            {
                dataLines = new List<string>(System.IO.File.ReadAllLines(path));
                sw.WriteLine(pChatter);


                var newPlayerNick = Instantiate(chat);
                newPlayerNick.transform.SetParent(canvas);
                newPlayerNick.text = pChatter;
                PlayerPrefs.SetString(pChatter, pChatter);

            }



            // DataLines = File.ReadAllLines(Data).ToList();


        }

        if (pMessage.Contains(komutlar[0]))
        {
            if (PlayerPrefs.GetString(pChatter) == komutlar[0])
            {
                Debug.Log("Zaten " + komutlar[0]+"Yazd�n @" + pChatter);

            }
            else
            {
                movement.Jump();
                PlayerPrefs.SetString(pChatter, komutlar[0]);

            }
        }

    }

}
