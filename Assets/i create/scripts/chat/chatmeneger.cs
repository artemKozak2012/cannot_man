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
    [SerializeField] Text chatText;
    [SerializeField] InputField textMessege;
    [SerializeField] InputField textusername;
    [SerializeField] InputField inputname;

    [SerializeField] string userID;
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
        chatText.text = " you connected to chat!";
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
            chatText.text = $"[{channelName}]{senders[i]}:{messages[i]}";
            Debug.Log($"OnGetMessages" + senders[i]);
        }
    }

    public void OnPrivateMessage(string sender, object message, string channelName)
    {
        chatText.text = $"[{channelName}]{sender}:{message}";
        Debug.Log($"OnPrivateMessage" + sender);
    }

    public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
    {
        Debug.Log($"OnStatusUpdate {user} sdf");
    }

    public void OnSubscribed(string[] channels, bool[] results)
    {
        for (int i = 0; i < channels.Length; i++)
        {
         chatText.text = $"you connected to {channels[i]}";
        }
           
    }

    public void OnUnsubscribed(string[] channels)
    {
        for (int i = 0; i < channels.Length; i++)
        {
            chatText.text += $"you disconected {channels[i]}";
        }
    }

    public void OnUserSubscribed(string channel, string user)
    {
        chatText.text += $"user{user} connected to {channel}";
    }

    public void OnUserUnsubscribed(string channel, string user)
    {
        chatText.text += $"user{user} unconnected from {channel}";
    }

    private void Start()
    {
        chatClient = new ChatClient(this);
        //chatClient.Connect(PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat, PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion, new AuthenticationValues(textuzername.text));
    }
    private void Update()
    {
       
        chatClient.Service();
    }
    public void SentButton()
    {
        if(textMessege.text != "")
        {
            chatClient.PublishMessage("globalChat", textMessege.text);
        }
        else
        {
            Debug.Log($"cannot send empty message");
        }
    }

    [ContextMenu("test")]
    public void SetName()
    {
       

        Debug.Log($"Set name {textusername.text}");
    }

    public void LoginButton()
    {
        
        userID = inputname.text;
        chatClient.Connect(PhotonNetwork.PhotonServerSettings.AppSettings.AppIdChat, PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion, new AuthenticationValues(textusername.text));
        
    }
}
