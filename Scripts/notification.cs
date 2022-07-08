using UnityEngine;
using Firebase.Messaging;
public class notification : MonoBehaviour
{
    void Start()
    {
        Firebase.Messaging.FirebaseMessaging.TokenReceived += GetToken;
        Firebase.Messaging.FirebaseMessaging.MessageReceived += GetMessage;
    }
    private void GetToken(object s, TokenReceivedEventArgs token){
        Debug.Log("Token alındı" + token.Token);
    }
    private void GetMessage(object s,MessageReceivedEventArgs message){
        Debug.Log("Mesaj Alındı" + message.Message);
    }
}
