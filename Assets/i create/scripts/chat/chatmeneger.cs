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
        Debug.Log($"");
    }

    public void OnConnected()
    {
        Debug.Log($"");
    }

    public void OnDisconnected()
    {
        Debug.Log($"");
    }

    public void OnGetMessages(string channelName, string[] senders, object[] messages)
    {
        Debug.Log($"");
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
        Debug.Log($"");
    }

    public void OnUnsubscribed(string[] channels)
    {
        Debug.Log($"");
    }

    public void OnUserSubscribed(string channel, string user)
    {
        Debug.Log($"");
    }

    public void OnUserUnsubscribed(string channel, string user)
    {
        Debug.Log($"");
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
            chatClient.PublishMessage("globalChal", textMessege);
        }
    }
}
