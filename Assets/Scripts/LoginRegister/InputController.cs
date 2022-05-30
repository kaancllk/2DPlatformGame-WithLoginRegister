using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
public class InputController 
{
    public void RegisterInputController(InputField _email, InputField _username, InputField _password, InputField _repeatPassword, Button _registerButton)
    {
        switch (_email.text.IndexOf('@') < 0 || _email.text.IndexOf('.') < 0 || _password.text.Length < 6 || _repeatPassword.text != _password.text || _username.text.Length < 6)

        {
            case true:
                _registerButton.interactable = false;
                break;
            default:
                _registerButton.interactable = true;
                break;
        }
        _username.text = Regex.Replace(_username.text, "[þ,Þ,ð,Ð,ç, ?, ü, ?, ö, ?, ?, ?, Ü, Ö, ?, Ç,.]", "");
        _password.text = Regex.Replace(_password.text, "[ç, ?, ü, ?, ö, ?, ?, ?, Ü, Ö, ?, Ç]", "");
    }
}
    
