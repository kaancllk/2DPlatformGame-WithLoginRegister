using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
public class RegisterBase 
{
    public bool Register_Asyc;
    public void Register(InputField _email, InputField _username, InputField _password)
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest() { Email = _email.text, Username = _username.text, Password = _password.text }, Result => { Debug.Log("Kay�tBa�ar�l�"); Register_Asyc = true; }, Error => { Debug.Log("Kay�tBa�ar�s�z"); Register_Asyc = false; });
    }
}
