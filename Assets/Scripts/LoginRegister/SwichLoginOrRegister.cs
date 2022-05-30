using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichLoginOrRegister : MonoBehaviour
{
    [SerializeField] GameObject _loginPanel, _RegisterPanel;

    public void SwichPanel()
    {
        switch (_loginPanel.activeInHierarchy)
        {
            case true:
                _RegisterPanel.SetActive(true);
                _loginPanel.SetActive(false);
                break;
            default:
                _RegisterPanel.SetActive(false);
                _loginPanel.SetActive(true);

                break;

        }
    }
}
