using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LobyManager : MonoBehaviourPunCallbacks
{
  
    void Start()
    {
        PhotonNetwork.NickName = "player" + Random.Range(1000, 9999);
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        Debug.Log("connect to master");
    }
    
    public void CraateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions {MaxPlayers = 10 });
    }
    
    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }
     
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined to the room");
        PhotonNetwork.LoadLevel("game");
    }



}
