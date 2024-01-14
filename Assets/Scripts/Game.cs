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
            //Debug.Log("111");
            Rat rat = FindObjectOfType<Rat>();
            if (rat != null)
            {
                Destroy(rat.gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var go = Instantiate(_objectToInstantiate);
            var component = go.GetComponent<Rat>();
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
