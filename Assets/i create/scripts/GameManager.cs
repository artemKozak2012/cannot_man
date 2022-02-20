using UnityEngine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Photon.Realtime;
using System;

public class GameManager : MonoBehaviourPunCallbacks
{
    public static event Action PlayerCreated;
     public Joystick joystick;
    public GameObject PlayerPrefab;

    private void Start()
    {
        GameObject playerGO = PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(UnityEngine.Random.Range(-209.67f, -203.8f), UnityEngine.Random.Range(7.2f, 2.4f)),Quaternion.identity) ;
        PlayerController player = playerGO.GetComponent<PlayerController>();
        player.Joystick = joystick;
        PlayerCreated?.Invoke();

    }
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat($"Player {newPlayer.NickName} entered game");
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat($"Player {otherPlayer.NickName} left game"); 
 }
   public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }
  } 
//:)