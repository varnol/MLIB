using System;
using Unity.VisualScripting;
using UnityEngine;

public class Captain : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpSpeed;
    public ratSpawner _ratSpawner;
    public Rigidbody _rb;
    public int _jump;
    public int _score;

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
            
            if
                (_jump==0)

            {Debug.Log(_jump);
                _rb.AddForce(Vector3.up * _jumpSpeed);
                _jump ++;
            }
        }

    }
   

    private void OnDestroy()
	{
		Debug.Log("Cap destroyed");
	}


    //captain gets spawner method
    public void SetSpawner(ratSpawner spawner)
    {
        _ratSpawner = spawner;
    }
//Registering self in Game List
    public void SetGame(Game value)
    {
        value.Register(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(message: $"Capt collision enter{other.gameObject.name}");
        _ratSpawner.spawn(); 
    }
    //private void OnCollisionEnter(Collision other)
    //{
    //    Rat component = other.gameObject.GetComponent<Rat>();
    //    if (component != null)
    //    {
    //        Destroy(other.gameObject);
    //        _score++;
    //        Debug.Log(message: _score);

    //    }

    //    Ship component2 = other.gameObject.GetComponent<Ship>();
    //    if (component != null)
    //    {
    //        _jump = 0;
    //        Debug.Log(message: "perviy");

    //    }
    //}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Rat>() != null)
        {
            Destroy(other.gameObject);
                   _score++;
                   Debug.Log(message: _score);
        }

        if(other.gameObject.GetComponent<Ship>() != null)
        {
            _jump = 0;
            Debug.Log(message: "perviy");
        }
    }

}