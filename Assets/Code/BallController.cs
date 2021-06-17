using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 7.0f;
    public GameObject ball;
    public Transform Ball;
    public Transform spawn;

    public float zero = 0;



    // Start is called before the first frame update
    void Start()
    {


        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    void Update()
    {



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






}