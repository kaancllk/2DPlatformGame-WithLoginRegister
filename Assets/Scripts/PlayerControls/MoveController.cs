using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IMove
{
    public float Horizontal => Input.GetAxis("Horizontal") * Time.deltaTime;

    public float Vertical => Input.GetAxis("Vertical") * Time.deltaTime;

    public float Jump => Input.GetAxis("Jump");

    public void HorizontalMove(Transform _transform,float _speed,bool _ishorizontalActive,Animator _anim)
    {
        switch (_ishorizontalActive)
        {
            case true:
                _transform.position += new Vector3(Horizontal * _speed, 0);
                _anim.SetFloat("__speed", Mathf.Abs(Input.GetAxis("Horizontal")));
                break;
            default:
                break;
        }
    }
    public void VerticalMove(Transform _transform, float _speed,bool _isverticalActive,Animator _anim)
    {
        switch (_isverticalActive)
        {
            case true:
                _anim.SetBool("__climb", true);
                _transform.position += new Vector3(0, Vertical * _speed);
                break;
            default:
                break;
        }

    }
    public void Jumping(Rigidbody2D _rb2D,float _jumpForce,bool _isjumpActive)
    {
        switch (_isjumpActive)
        {
            case true:
                _rb2D.AddForce(Vector2.up * _jumpForce);
                
                break;

            default:
                //_isjumpActive = false;
                break;
        }

    }
    public void Flip(SpriteRenderer _spriteRenderer,bool _isflipActive)
    {
        switch (_isflipActive)
        {
            case true:
                if (Horizontal < 0)
                {
                    _spriteRenderer.flipX = true;
                }
                
                
                else if (Horizontal>0)
                {
                    _spriteRenderer.flipX = false;
                }
                break;
            default:
                _isflipActive = false;
                break;
        }
    }
}
