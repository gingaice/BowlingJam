using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFishWeBalin : MonoBehaviour
{

    public Rigidbody m_rigidbody;

    public int num;

    public bool freezeAngles;

    // Start is called before the first frame update
    void Start()
    {
        freezeAngles = false;

        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            freezeAngles = true;
        }

        if(freezeAngles == true)
        {

        }
    }
}
