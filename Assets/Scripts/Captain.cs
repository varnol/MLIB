using System;
using Unity.VisualScripting;
using UnityEngine;

public class Captain : MonoBehaviour
{
    public float _movementSpeed;
    public float _rotationSpeed;

    private void Awake()
	{
		Debug.Log("Cap awaked");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(translation: Vector3.forward * _movementSpeed);
            //Vector3 tmp = transform.position;
            //tmp.z +=_movementSpeed;
            //transform.position = tmp;

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(translation: Vector3.back * _movementSpeed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -_rotationSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, _rotationSpeed);

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
//Registering self in Game List
    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }
}