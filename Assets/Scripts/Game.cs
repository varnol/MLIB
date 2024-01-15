using System;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject _objectToInstantiate;

private readonly List<GameObject> _objectsToDestroy = new();


    private void Update()
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
            var go = Instantiate(_objectToInstantiate);
            var component = go.GetComponent<Captain>();
            if (component != null)
            {
                component.SetGame(this);
            }

        }
    }
    public void Register(GameObject objectToDestroy)
    {
        _objectsToDestroy.Add(objectToDestroy);
    }
}
