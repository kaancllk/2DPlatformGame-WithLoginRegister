using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpeed : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb2D;
    [SerializeField] float _moveSpeed;

    private void Start()
    {
        EagleMove();
    }

    void EagleMove()
    {
        if (this.gameObject.CompareTag("Eagle"))
        {
            _rb2D.velocity = Vector2.left * _moveSpeed;
        }
    }
}
