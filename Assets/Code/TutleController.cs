using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutleController : MonoBehaviour
{
    public float speed = 25.0f;
    public GameObject turtle;

    public float _speedfling = 0;
    public bool _isPressed;
    public float _speedHeld = 0;
    public float number = 15;

    private Rigidbody m_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
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
            _speedHeld += number * Time.deltaTime;
            float _speedfling = Time.deltaTime * _speedHeld;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _isPressed = true;
            //_speedHeld += number * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _isPressed = false;
            //float _speedfling = Time.deltaTime * _speedHeld;
            //transform.rotation = Quaternion.AngleAxis(_speedfling, Vector3.right);
            m_rigidbody.velocity = _speedfling * transform.forward;
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
}