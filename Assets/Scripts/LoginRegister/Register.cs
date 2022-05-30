using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Register : MonoBehaviour
{
    RegisterBase _registerBase;
    InputController _inputController;

    [SerializeField] InputField _email, _username, _password, _repeatPassword;
    [SerializeField] Button _registerButton;

    private void Awake()
    {
        _inputController = new InputController();
        _registerBase = new RegisterBase();
    }
    IEnumerator AsyncControl()
    {
        _registerBase.Register(_email, _username, _password);
        yield return new WaitUntil(() => _registerBase.Register_Asyc);
        Debug.Log("aaa");
    }


    public void RegisterOnClick()
    {
        StartCoroutine(AsyncControl());
    }

    public void RegisterInputController()
    {
        _inputController.RegisterInputController(_email, _username, _password, _repeatPassword, _registerButton);
    }

    
}
