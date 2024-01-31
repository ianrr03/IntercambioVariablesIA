using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class UIInformacion : MonoBehaviourPunCallbacks, IPunObservable//hacemos que sea observable
{
    //variables
    public TMP_Text informacion; //texto del banner
    public int playerNun; // Numero de jugador
    void Start()
    {
        StartCoroutine("SetPlayerOrEnemy"); //poco a poco se va ejecutando en segundo plano
    }

    IEnumerator SetPlayerOrEnemy()
    {
        yield return new WaitForSeconds(3); //tarda en ejecutarse 3 segundos por eso esta en el start
        if (photonView.IsMine) //El photonWiew es mio
            informacion.text = "Yo soy el jugador";
        if (!photonView.IsMine) //No
            informacion.text = "Soy el enemigo";
    }//SetPlayerOrEnemy

   
    void Update()
    {
        
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
       // throw new System.NotImplementedException();
    }//OnPhotonSerializeView

}//UIInformacion
