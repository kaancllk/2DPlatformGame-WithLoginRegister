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
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest() { Email = _email.text, Username = _username.text, Password = _password.text }, Result => { Debug.Log("KayýtBaþarýlý"); Register_Asyc = true; }, Error => { Debug.Log("KayýtBaþarýsýz"); Register_Asyc = false; });
    }
}
