using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    LoginBase _loginBase;

    [SerializeField] InputField _emailorUsername, _password;
    [SerializeField] Button _loginButton,_questLoginButton;
    bool _questLogin;
    private void Awake()
    {
        _loginBase = new LoginBase();
    }
    public void LoginOnClick()
    {
        _loginBase.SwichEmailorUsername(_emailorUsername, _password);
    }
    public void QuestLoginOnClick()
    {
        _loginBase.QuestLogin(_questLogin);
    }
 }
