using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPicker : MonoBehaviour
{
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;
    public static bool isSpinster = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            SpinWheel();
        }

        if (isSpinning == true)
        {
            transform.Rotate(0, 0, genSpeed, Space.World);
            genSpeed -= subSpeed;
        }
        if(genSpeed <= 0)
        {
            genSpeed = 0;
            isSpinning = false;
            isSpinster = false;
        }
    }


    //need to make it with triggers so when the little pingy enters the trigger

    public void SpinWheel()
    {
        genSpeed = Random.Range(2.0f, 5.0f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
        isSpinster = true;
    }
}

/**    
 * 
 *         if (_spawnedIn1 == true)
        {
            _BowlBall.position = spawn.position;
        }

        if (_spawnedIn2 == true)
        {
            _Fridge.position = spawn.position;
        }

        if (_spawnedIn3 == true)
        {
            _manLegs.position = spawn.position;
        }

        if (_spawnedIn4 == true)
        {
            _Toaster.position = spawn.position;
        }

        if (_spawnedIn5 == true)
        {
            _fish.position = spawn.position;
        }

        if (_spawnedIn6 == true)
        {
            _fireEx.position = spawn.position;
        }


 * private void OnTriggerEnter(Collider other)
    {
        if (other.name == "bowlin")
        {
            if (isSpinning == false)
            {
                _spawnedIn1 = true;
            }
        }

        if (other.name == "frige")
        {
            if (isSpinning == false)
            {
                _spawnedIn2 = true;
            }
        }

        if (other.name == "men legs")
        {
            if (isSpinning == false)
            {
                _spawnedIn3 = true;
            }
        }

        if (other.name == "toaster")
        {
            if (isSpinning == false)
            {
                _spawnedIn4 = true;
            }
        }

        if (other.name == "fish")
        {
            if (isSpinning == false)
            {
                _spawnedIn5 = true;
            }
        }

        if (other.name == "fire")
        {
            if (isSpinning == false)
            {
                _spawnedIn6 = true;
            }
        }
    }
**/