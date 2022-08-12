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



    public List<string> dataLines;
    public List<string> newPlayers;

    private void Start()
    {
        path = Application.dataPath + "/playersData.txt";


        membersPath = Application.dataPath + "/members.txt";
        sw = new StreamWriter(membersPath);


    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            File.WriteAllText(path, "");
            File.WriteAllText(membersPath, "");
        }


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            sw.Close();

        }

    }
    public void OnChatMessage(string pChatter, string pMessage)
    {
        if (pMessage.Contains("!"))
        {
            if (membersLine.Contains(pChatter))
            {
                Debug.Log("Zaten Katýldýn!");
            }
            else
            {
                chat.text = (pChatter);

                sw.WriteLine(pChatter);
            }



            // DataLines = File.ReadAllLines(Data).ToList();


        }

    }

}
