using System;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject _objectToInstantiate;
    public Transform _capSpawnPoint;

//creating the array of objects
private readonly List<GameObject> _objectsToDestroy = new();

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (_objectsToDestroy.Count > 0)
            {
                Destroy(_objectsToDestroy[0]);
                _objectsToDestroy.RemoveAt(index:0);
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var go = Instantiate(_objectToInstantiate,_capSpawnPoint.position, _capSpawnPoint.rotation);
            var component = go.GetComponent<Captain>();
            if (component != null)
            {
                component.SetGame(this);
                //component.SetSpawner(_ratSpawner);
            }

        }
    }

    //registering objects in array
    public void Register(GameObject objectToDestroy)
    {
        _objectsToDestroy.Add(objectToDestroy);
    }
}
