using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;
public class LoginBase 
{
    public void LoginEmail(InputField _email,InputField _password)
    {
        PlayFabClientAPI.LoginWithEmailAddress(new LoginWithEmailAddressRequest() { Email = _email.text, Password = _password.text }, Result => { Debug.Log("Email Giri� Ba�ar�l�"); SceneManager.LoadScene(1); }, Error => { Debug.Log("Email Giri� Ba�ar�s�z"); });
    }
    public void LoginUsername(InputField _username, InputField _password)
    {
        PlayFabClientAPI.LoginWithPlayFab(new LoginWithPlayFabRequest() { Username = _username.text, Password= _password.text }, Result => { Debug.Log("Username Giri� Ba�ar�l�"); SceneManager.LoadScene(1); }, Error => { Debug.Log("Username Giri� Ba�ar�s�z"); }); 
    }
     public void SwichEmailorUsername(InputField _emailorUsername, InputField _password)
    {
        switch (_emailorUsername.text.IndexOf('@')<0)
        {
            case true:
                LoginUsername(_emailorUsername,_password);
                break;
            default:
                LoginEmail(_emailorUsername, _password);
                break;
        }
    }
    public void QuestLogin(bool _questLogin)
    {
        PlayFabClientAPI.LoginWithAndroidDeviceID(new LoginWithAndroidDeviceIDRequest() { AndroidDeviceId = SystemInfo.deviceUniqueIdentifier, CreateAccount = _questLogin }, Result => { Debug.Log("Misafir Giri� Ba�ar�l�"); SceneManager.LoadScene(1); }, Error => { Debug.Log("Misafir Giri� Ba�ar�s�z"); });
    }
}
