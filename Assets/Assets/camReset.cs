using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camReset : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;

    // Start is called before the first frame update
    void Start()
    {
        Cam1.enabled = true;
        Cam2.enabled = false;
        Cam3.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Cam1.enabled = true;
            Cam2.enabled = false;
            Cam3.enabled = false;
        }
    }
   
}