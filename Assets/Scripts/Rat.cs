using System;
using Unity.VisualScripting;
using UnityEngine;

public class Rat : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("Rat awaked");
	}

	//private void Start()
	//{
	//	Debug.Log("Rat started");
	//}

    //private void Update()
    //{
    //Debug.Log("Rat monster updated");
    // }
    //
    // private void FixedUpdate()
    // {
    // 	Debug.Log("Rat monster fixed updated");
    // }
    //
    // private void LateUpdate()
    // {
    // 	Debug.Log("Rat monster late updated");
    // }

    //private void OnEnable()
    //{
    //    Debug.Log("Rat monster enabled");
    //}

    // private void OnDisable()
    // {
    // 	Debug.Log("Rat monster disabled");
    // }

    private void OnDestroy()
	{
		Debug.Log("Rat destroyed");
	}

    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }
}