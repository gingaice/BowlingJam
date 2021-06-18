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
    public AudioSource audioSource;
    public AudioClip roll;

    // Start is called before the first frame update
    void Start()
    {
        freezeAngles = false;
        startPower = false;

        m_rigidbody = GetComponent<Rigidbody>();

        Multiplier = 2.2f;

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
            if (Input.GetKeyDown(KeyCode.UpArrow) && num == 3)// when pressed lauches ball
            {
                num = 5;
                startPower = false;
                Debug.Log("stop");
                StopCoroutine(Timer());
                m_rigidbody.velocity = shootPower * transform.forward;
            }
        }

        if(startPower == true && num == 2)
        {
            num = 3;
            StartCoroutine(Timer());
            Debug.Log("start");
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = roll;
            audioSource.Play();
            Debug.Log("audioplaying");
        }

        if(up == true)
        {
            shootPower += Multiplier;
        }

        if (down == true)
        {
            shootPower -= Multiplier;
        }

        if(shootPower <= 0)
        {
            down = false;
        }

    }

    IEnumerator Timer()
    {

        down = false;
        up = true;
        Debug.Log("up");
        yield return new WaitForSeconds(0.5f);
        up = false;
        down = true;
        Debug.Log("down");
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Timer());
    }
}
