using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundCheck : MonoBehaviour
{
    [SerializeField] Transform[] _transform;
    [SerializeField] LayerMask _layermask;
    [SerializeField] float _maskDistance;
    [SerializeField] bool _isonGround = false;
    [SerializeField] Animator _anim;

    public bool isonGround => _isonGround;
    private void Update()
    {
        foreach (Transform transform in _transform)
        {
            OnGround(transform);
            if (_isonGround) break;
            {

            }
            
        }
    }
    void OnGround(Transform _transform)
    {
        RaycastHit2D hit = Physics2D.Raycast(_transform.position, _transform.forward, _maskDistance, _layermask);
        Debug.DrawRay(_transform.position, _transform.forward * _maskDistance, Color.red);
       
        if (hit.collider !=null)
        {
            _isonGround = true;
            _anim.SetBool("__jump",false);
        }
        else  
        {
            _isonGround = false;
            _anim.SetBool("__jump", true);
        }
    }
}
