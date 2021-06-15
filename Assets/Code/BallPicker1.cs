using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPicker1 : MonoBehaviour
{
    public Transform _BowlBall;
    public Transform _Fridge;
    public Transform _Toaster;
    public Transform _fireEx;
    public Transform _manLegs;
    public Transform _fish;

    public Transform spawn;

    public bool _spawnedIn1;
    public bool _spawnedIn2;
    public bool _spawnedIn3;
    public bool _spawnedIn4;
    public bool _spawnedIn5;
    public bool _spawnedIn6;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(_spawnedIn1 == true)
        {
            _BowlBall.position = _BowlBall.position;
        }

        if (_spawnedIn2 == true)
        {
            _Fridge.position = _BowlBall.position;
        }

        if (_spawnedIn3 == true)
        {
            _manLegs.position = _BowlBall.position;
        }

        if (_spawnedIn4 == true)
        {
            _Toaster.position = _BowlBall.position;
        }

        if (_spawnedIn5 == true)
        {
            _fish.position = _BowlBall.position;
        }

        if (_spawnedIn6 == true)
        {
            _fireEx.position = _BowlBall.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "bowlin")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn1 = true;
            }
        }

        if (other.name == "frige")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn2 = true;
            }
        }

        if (other.name == "men legs")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn3 = true;
            }
        }

        if (other.name == "toaster")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn4 = true;
            }
        }

        if (other.name == "fish")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn5 = true;
            }
        }

        if (other.name == "fire")
        {
            if (BallPicker.isSpinning == false)
            {
                _spawnedIn6= true;
            }
        }
    }


}
