using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishWeBalin : MonoBehaviour
{

    public Rigidbody m_rigidbody;

    static public float shootPower;
    public float Multiplier;

    public float showShoot;

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

        Multiplier = 1;

        num = 1;

    }

    // Update is called once per frame
    void Update()
    {

        showShoot = shootPower;


        if (Input.GetKeyDown(KeyCode.UpArrow) && num == 1)
        {
            freezeAngles = true;
            startPower = true;
            num = 2;
        }



        if(freezeAngles == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && num == 2)// when pressed lauches ball
            {
                num = 3;
                startPower = false;
                Debug.Log("stop");
                StopCoroutine(Timer());
                m_rigidbody.velocity = shootPower * transform.forward;
            }
        }

        if(startPower == true && num != 5)
        {
            num = 5;
            StartCoroutine(Timer());
            Debug.Log("start");
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
        Debug.Log("up");
        yield return new WaitForSeconds(1);
        down = true;
        Debug.Log("down");
        yield return new WaitForSeconds(1);
        StartCoroutine(Timer());
    }
}
