using System;
using Unity.VisualScripting;
using UnityEngine;

public class Captain : MonoBehaviour
{
    public float _movementSpeed;
	private void Awake()
	{
		Debug.Log("Cap awaked");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Cap awaked");
            Vector3 tmp = transform.position;
            tmp.z +=_movementSpeed;
            transform.position = tmp;

        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 tmp = transform.position;
            tmp.z -= _movementSpeed;
            transform.position = tmp;

        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 tmp = transform.position;
            tmp.x += _movementSpeed;
            transform.position = tmp;

        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 tmp = transform.position;
            tmp.x -= _movementSpeed;
            transform.position = tmp;

        }
    }

//private void Start()
//{
//	Debug.Log("Cap started");
//}


//
// private void FixedUpdate()
// {
// 	Debug.Log("Cap  fixed updated");
// }
//
// private void LateUpdate()
// {
// 	Debug.Log("Caplate updated");
// }

//private void OnEnable()
//{
//    Debug.Log("Cap enabled");
//}

// private void OnDisable()
// {
// 	Debug.Log("Cap disabled");
// }

private void OnDestroy()
	{
		Debug.Log("Cap destroyed");
	}

    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }
}