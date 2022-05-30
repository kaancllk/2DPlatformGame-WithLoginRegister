using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    MoveController _moveController;
    [SerializeField] float _playerSpeed, _jumpForce, _climbSpeed;
    [SerializeField] bool _ishorizontalActive, _isverticalActive, _isjumpActive,_isflipActive;
    [SerializeField] Transform _transform;
    [SerializeField] Rigidbody2D _rb2D;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] Animator _anim;
    bool _spaceController=false;
    [SerializeField] GameObject _onGround;
    //Health _health;
    private void Awake()
    {
        
        //_health = GetComponent<Health>();
        _moveController = new MoveController();
    }
    private void FixedUpdate()
    {
        Horizontal();
        Flip();

        Jump();
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            
       
            _spaceController = true;
            
        }
    }
    void Horizontal()
    {
        _moveController.HorizontalMove(_transform, _playerSpeed, _ishorizontalActive, _anim);
    }
    void Vertical()
    {
        
        _moveController.VerticalMove(_transform, _climbSpeed, _isverticalActive,_anim);
    }
    void Jump()
    {
        if (_spaceController && _onGround.GetComponent<OnGroundCheck>().isonGround)
        {
            _moveController.Jumping(_rb2D, _jumpForce, _isjumpActive);
        }
        _spaceController = false;
    }
    void Flip()
    {
        _moveController.Flip(_spriteRenderer, _isflipActive);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _rb2D.gravityScale = 0f;
        Vertical();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _rb2D.gravityScale = 1f;
        _anim.SetBool("__climb", false);
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Damage damage = collision.collider.GetComponent<Damage>();
    //    if (damage!=null)
    //    {
    //        _health.TakeHit(damage);
    //        return;

    //    }
    //}


}
