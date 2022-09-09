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

    public List<string> players;
    public int playerNumber;
    public string cekilen;

    private void Start()
    {

        path = Application.dataPath + "/playersData.txt";


        membersPath = Application.dataPath + "/members.txt";
        sw = new StreamWriter(membersPath);

       /* membersKayit = System.IO.File.ReadLines(membersPath).ToList();
        membersLine = System.IO.File.ReadLines(membersPath).ToList();
       */

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
        if (pMessage.Contains("!join"))
        {
            if (PlayerPrefs.GetString(pChatter) == pChatter)
            {
                Debug.Log("Zaten Katýldýn!   "+pChatter);
            
            }
            else
            {
                dataLines = new List<string>(System.IO.File.ReadAllLines(path));
                sw.WriteLine(pChatter);
                List<string> playerss = new List<string>();
                
                    players.Add(pChatter);
            
                var newPlayerNick = Instantiate(chat);
                newPlayerNick.transform.SetParent(canvas);
                newPlayerNick.text = pChatter;
                PlayerPrefs.SetString(pChatter, pChatter);

            }



            // DataLines = File.ReadAllLines(Data).ToList();


        }


        if (pMessage.Contains("!jump"))
        {
            movement.Jump();
        }

    }

    public void cekilis()
    {
      
            string name = players[Random.Range(1,players.Count)];
            Debug.Log(name);


    }

}
