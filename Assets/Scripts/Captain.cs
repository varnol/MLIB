using System;
using Unity.VisualScripting;
using UnityEngine;

public class Captain : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private ratSpawner _ratSpawner;
    public Rigidbody _rb;
    public int _jump;

    public void Awake()
	{
        _jump = 0;
        //Debug.Log(_jump);
    }

    private void Start()
    {
    _rb = GetComponent<Rigidbody>();
    }
    public void Update()
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

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log(_jump);
            Debug.Log("_jump");
            if
                (_jump==0)

            {
                _rb.AddForce(Vector3.up * _jumpSpeed);
                _jump ++;
            }
        }

    }
   

    private void OnDestroy()
	{
		Debug.Log("Cap destroyed");
	}
//Registering self in Game List
    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(message: $"Capt collision enter{other.gameObject.name}");
        _ratSpawner.spawn(); 
    }
}