using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 7.0f;
    public GameObject ball;
    public Transform Ball;
    public Transform spawn;

    public float _speedfling = 0;
    public bool _isPressed;
    public float _speedHeld = 0;
    public float number = 169;

    public float zero = 0;

    private Rigidbody m_rigidbody;

    public int num; 

    // Start is called before the first frame update
    void Start()
    {
        num = 0;

        Cursor.lockState = CursorLockMode.Locked;

        _isPressed = false;

        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        _speedfling = _speedHeld;

        if (_isPressed == true)
        {
            _isPressed = false;
            Debug.Log("SATR");
            StartCoroutine(Power());
            
            //float _speedfling = Time.deltaTime * _speedHeld;

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _isPressed = true;

            num += 1;
            //_speedHeld += number * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(_isPressed == true)
            {
                if(num != 0)
                {
                    m_rigidbody.velocity = _speedfling * transform.forward;
                }
                
            }
        }


        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //_isPressed = false;
            //float _speedfling = Time.deltaTime * _speedHeld;
            //transform.rotation = Quaternion.AngleAxis(_speedfling, Vector3.right);
            //m_rigidbody.velocity = _speedfling * transform.forward;
        }

        //transform.TransformDirection(Vector3.forward) *


        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("respawner"))
        {
            Ball.position = spawn.position;
        }
    }
    IEnumerator Power()
    {
        _speedHeld += number;

        yield return new WaitForSeconds(2);

        _speedHeld -= number;

        yield return new WaitForSeconds(2);
        StartCoroutine(Power());
    }

}