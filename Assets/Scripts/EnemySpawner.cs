using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject _eagle;
    float _spawnTime;
    private void FixedUpdate()
    {
        _spawnTime += Time.deltaTime;
        if (_spawnTime >= 5)
        {
            EagleSpawn();
            _spawnTime = 0;
        }
    }
    void EagleSpawn()
    {
        Instantiate(_eagle, transform.position, transform.rotation);
    }
}
