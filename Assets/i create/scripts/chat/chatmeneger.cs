using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Chat;
using Photon.Pun;
using ExitGames.Client.Photon;
using UnityEngine.UI;

public class chatmeneger : MonoBehaviour, IChatClientListener
{
    ChatClient chatClient;
    [SerializeField] string userID;

    [SerializeField] Text chatText;
    [SerializeField] InputField textMessege;
    [SerializeField] InputField textuzername;

    public void DebugReturn(DebugLevel level, string message)
    {
        Debug.Log($"{level} {message}");
    }

    public void OnChatStateChange(ChatState state)
    {
        Debug.Log(state);
    }

    public void OnConnected()
    {
        chatText.text += "/n you connected to chat!";
        chatClient.Subscribe("globalChat");
    }

    public void OnDisconnected()
    {
        chatClient.Unsubscribe(new string[] { "globalChat" });
    }

    public void OnGetMessages(string channelName, string[] senders, object[] messages)
    {
     for(int i = 0;i < senders.Length;i++)
        {
            chatText.text += $"/n[{channelName}]{senders[i]}:{messages[i]}";
        }
    }

    public void OnPrivateMessage(string sender, object message, string channelName)
    {
        Debug.Log($"sdfsdf" + sender);
    }

    public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
    {
        Debug.Log($"sdf {user} sdf");
    }

    public void OnSubscribed(string[] channels, bool[] results)
    {
        for (int i = 0; i < channels.Length; i++)
        {
         chatText.text += $"you connected to {channels[i]}";
        }
           
    }

    public void OnUnsubscribed(string[] channels)
    {
        for (int i = 0; i < channels.Length; i++)
        {
            chatText.text += $"you unconected {channels[i]}";
        }
    }

    public void OnUserSubscribed(string channel, string user)
    {
        chatText.text += $"user{user} connected to {channel}";
    }

    public void OnUserUnsubscribed(string channel, string user)
    {
        chatText.text += $"user{user} unconnected {channel}";
    }

    private void Start()
    {
        chatClient = new ChatClient(this);
        chatClient.Connect(PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat, PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion, new AuthenticationValues(userID));
    }
    private void Update()
    {
        chatClient.Service();
    }
    public void SentButton()
    {
        if(textuzername.text == "")
        {
            chatClient.PublishMessage("globalChat", textMessege.text);
        }
    }
}
