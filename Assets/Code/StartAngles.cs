using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAngles : MonoBehaviour
{

    public bool Angles;
    public bool Power;
    public bool canShoot;
    public bool Prep;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = false;
        Angles = false;
        Power = false;
        Prep = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Prep == true)
        {

        }
    }
}
