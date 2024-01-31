using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;
using TMPro;


public class ManejadorRed : MonoBehaviourPunCallbacks
{
    public TMP_Text informacion;
    public static ManejadorRed manejadorRed;
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        informacion.text = "Conectando al servido";
        print(informacion.text);
        Debug.Log("Conectando al servidor");
    }//OnConnectedToMaster

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Sala", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }
    void Update()
    {
        
    }
}
