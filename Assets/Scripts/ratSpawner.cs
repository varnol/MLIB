using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratSpawner : MonoBehaviour
{
    public float _timeToSpawn;
    public GameObject _enemyPrefab;
    public Transform[] _spawnPoints;

    private float _currentTimer;

    private void Start()
    {
        ResetTimer();
    }

   
    private void Update()
    {
       
        _currentTimer -= Time.deltaTime;

        if (_currentTimer <= 0.0f)
        {
            int index = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab,_spawnPoints[index].position, _spawnPoints[index].rotation);
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        _currentTimer = _timeToSpawn;
    }
}
