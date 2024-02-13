using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratSpawner : MonoBehaviour
{
    public float _timeToSpawn;
    public GameObject _enemyPrefab;
    public Transform[] _spawnPoints;

    public float _currentTimer;

    public void Start()
    {
        ResetTimer();
    }

   
    public void Update()
    {

        _currentTimer -= Time.deltaTime;

        if (_currentTimer <= 0.0f)
        {
            spawn();
            ResetTimer();
        }
    }

    public void ResetTimer()
    {
        _currentTimer = _timeToSpawn;
    }
    public void spawn()
    {
    int index = Random.Range(0, _spawnPoints.Length);
    Instantiate(_enemyPrefab, _spawnPoints[index].position, _spawnPoints[index].rotation);
    
}
}
