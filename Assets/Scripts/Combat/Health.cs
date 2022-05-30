using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _maxHealth=3;
    [SerializeField] int _currentHealth=0;
    bool _isDead;
    public bool IsDead => _currentHealth < 0;
    private void Awake()
    {
        _currentHealth = _maxHealth;
    }
    public void TakeHit(Damage damage)
    {

        if (!IsDead)
        {
            _currentHealth -= damage.HitDamage;
        }
            
        
        
    }
}
