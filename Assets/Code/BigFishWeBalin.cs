using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishWeBalin : MonoBehaviour
{

    public Rigidbody m_rigidbody;

    public float shootPower;
    public float Multiplier;

    public int num;

    public bool freezeAngles;
    public bool startPower;

    public bool up;
    public bool down;

    // Start is called before the first frame update
    void Start()
    {
        freezeAngles = false;
        startPower = false;

        m_rigidbody = GetComponent<Rigidbody>();

        Multiplier = 31;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            freezeAngles = true;
            startPower = true;
        }

        if(freezeAngles == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))// when pressed lauches ball
            {
                startPower = false;
                StopCoroutine(Timer());
                m_rigidbody.velocity = shootPower * transform.forward;
            }
        }

        if(startPower == true)
        {
            StartCoroutine(Timer());
        }

        if(up == true)
        {
            shootPower += Multiplier;
        }

        if (down == true)
        {
            shootPower -= Multiplier;
        }

    }

    IEnumerator Timer()
    {
        up = true;
        yield return new WaitForSeconds(1);
        down = true;
        yield return new WaitForSeconds(1);
        StartCoroutine(Timer());
    }
}
