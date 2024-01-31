using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class ControladorPuntos : MonoBehaviourPunCallbacks
{
    public TMP_InputField VariableLocalInput; //Caja de texto de entrada
    public TMP_Text VariableLocalText;
    public TMP_Text VariableRedText;

    //Variable para modificar en red
    public string tomarDatosRival = "0";

    //Cuando se introducen valores en el inputField 
    //Tendran que sincronizarse

    public void CambiarValor()
    {
        string value = VariableLocalInput.text;
        VariableLocalText.text = value; //El jugador local cambia el valor, cambia su puntuacion
        //Ahora tendremos que avisar al otro jugador para que lo cambie
        photonView.RPC(nameof(CambiarValorEnRed),RpcTarget.OthersBuffered, value);
    }//Cambiar valor

    [PunRPC]
    void CambiarValorEnRed(string variable)
    {
        VariableRedText.text = variable; //cambia el vaor del otro jugador
    }

    void Start()
    {
        
    }//Start

    
    void Update()
    {
        
    }//Update
}
