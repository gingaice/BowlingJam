using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPicker1 : MonoBehaviour
{
    public Transform _Chosen;

    public Transform spawn;

    public bool _spawnedIn = false;

    public bool spinNo = false; 


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (BallPicker.isSpinster == false)
        {
            spinNo = true;
        }
        else
        {
            spinNo = false;
        }


        if (_spawnedIn == true)
        {
            if(spinNo == true)
            {
                _Chosen.position = spawn.position;
            }
        }
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "picker")
        {
            _spawnedIn = true;
            Debug.Log("pp");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "picker")
        {
            _spawnedIn = false;
            Debug.Log("popo");
        }
    }
}
