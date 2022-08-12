using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.IO;
using UnityEngine.Events;

public class twitchConnection : MonoBehaviour
{
    public UnityEvent<string, string> OnChatMessage;

    TcpClient twitch;
    StreamReader reader;
    StreamWriter writer;

    const string URL = "irc.chat.twitch.tv";
    const int PORT = 6667;

   public string User;
   public string oAuth;
    public string Channel;

    float pingCounter;


    private void Start()
    {

    }
    private void ConnectToTwitch()
    {
        twitch = new TcpClient(URL, PORT);
        reader = new StreamReader(twitch.GetStream());
        writer = new StreamWriter(twitch.GetStream());

        writer.WriteLine("PASS " + oAuth);
        writer.WriteLine("NICK " + User.ToLower());
        writer.WriteLine("JOIN #" + Channel.ToLower());
        writer.Flush();

    }


    private void Awake()
    {
        User = PlayerPrefs.GetString("channel");
        Channel = PlayerPrefs.GetString("channel");
        oAuth = PlayerPrefs.GetString("oAuth");
        Debug.Log(PlayerPrefs.GetString("channel") + "    -     " + PlayerPrefs.GetString("oAuth"));
     
        ConnectToTwitch();
    }
    private void Update()
    {
        pingCounter += Time.deltaTime;
        if (pingCounter > 60)
        {
            writer.WriteLine("PING"+URL);
            writer.Flush();
            pingCounter = 0;

        }
        if (!twitch.Connected)
        {
            ConnectToTwitch();
        }
        if (twitch.Available > 0)
        {
            string message = reader.ReadLine();
            if (message.Contains("PRIVMSG"))
            {
                int splitPoint = message.IndexOf("!");
                string chatter = message.Substring(1, splitPoint - 1);

                splitPoint = message.IndexOf(":",1);
                string msg = message.Substring(splitPoint + 1);

                OnChatMessage?.Invoke(chatter, msg);
               
            }
            print(message);
        }

    }

}
