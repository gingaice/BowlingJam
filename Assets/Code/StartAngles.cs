using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAngles : MonoBehaviour
{

    public Transform Left;
    public Transform Right;

    public bool Angles;
    public bool Power;
    public bool canShoot;
    public bool Prep;
    public bool movingRight;
    public bool movingLeft;
    public bool goingRight;
    public bool goingLeft;

    public bool turnOff;
    public int num;

    public float rotateSpeed;

    public float tickSpeed;
    public float halfSpeed;

    // Start is called before the first frame update
    void Start()
    {

        num = 1;
        movingLeft = false;

        canShoot = false;
        Angles = false;
        Power = false;
        Prep = true;

        rotateSpeed = 4.0f;
        tickSpeed = 0.4f;
        halfSpeed = 0.2f;



    }

    // Update is called once per frame
    void Update()
    {
        float singleStep = rotateSpeed * Time.deltaTime;

        Vector3 leftDirection = Left.position - transform.position;
        Vector3 newerDirection = Vector3.RotateTowards(transform.forward, leftDirection, singleStep, 0.0f);

        Vector3 rightDirection = Right.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, rightDirection, singleStep, 0.0f);

        if (goingRight == true)
        {
            Debug.Log("right");
            transform.rotation = Quaternion.LookRotation(newDirection);
        }

        if (goingLeft == true)
        {
            Debug.Log("left");
            transform.rotation = Quaternion.LookRotation(newerDirection);
        }

        if (Prep == true)
        {
            Angles = true;
            Prep = false;
        }

        if (Angles == true)
        {
            movingRight = true;
            Angles = false;
        }

        if(num != 0)
        {
            num = 0;
            StartCoroutine(Ang());
        }

        if (movingRight == true)
        {
            num += 1;
            movingRight = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            num = 0;
            goingLeft = false;
            goingRight = false;
            StopAllCoroutines();
        }
    }

    IEnumerator Ang()
    {
        goingRight = true;


        yield return new WaitForSeconds(halfSpeed);

        goingRight = false;
        goingLeft = true;

        yield return new WaitForSeconds(tickSpeed);

        goingLeft = false;
        goingRight = true;


        yield return new WaitForSeconds(tickSpeed);

        goingRight = false;
        goingLeft = true;

        yield return new WaitForSeconds(tickSpeed);

        goingRight = true;
        goingLeft = false;

        yield return new WaitForSeconds(halfSpeed);

        StartCoroutine(Ang());
    }

}
