using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPickerPick : MonoBehaviour
{
    public Transform _BowlBall;
    public Transform _Fridge;
    public Transform _ManLegs;
    public Transform _Toaster;
    public Transform _Fish;
    public Transform _FireEx;

    public Transform spawn;

    public bool _spawnedIn1 = false;
    public bool _spawnedIn2 = false;
    public bool _spawnedIn3 = false;
    public bool _spawnedIn4 = false;
    public bool _spawnedIn5 = false;
    public bool _spawnedIn6 = false;

    public bool spinNo = false;
    // Start is called before the first frame update
    void Start()
    {

    }

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

        if(spinNo == true)
        {
            if (_spawnedIn1 == true)
            {
                Debug.Log("OwO");
                _BowlBall.position = spawn.position;
            }

            if (_spawnedIn2 == true)
            {
                Debug.Log("OwO");
                _Fridge.position = spawn.position;
            }

            if (_spawnedIn3 == true)
            {
                Debug.Log("OwO");
                _ManLegs.position = spawn.position;
            }

            if (_spawnedIn4 == true)
            {
                Debug.Log("OwO");
                _Toaster.position = spawn.position;
            }

            if (_spawnedIn5 == true)
            {
                Debug.Log("OwO");
                _Fish.position = spawn.position;
            }

            if (_spawnedIn6 == true)
            {
                Debug.Log("OwO");
                _FireEx.position = spawn.position;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obj"))
        {
            Debug.Log("OwO");

            if (other.gameObject.name == "BowlinBall")
            {
                _spawnedIn1 = true;
            }

            if (other.gameObject.name == "Fridge")
            {
                _spawnedIn2 = true;
            }

            if (other.gameObject.name == "ManLeg")
            {
                _spawnedIn3 = true;
            }

            if (other.gameObject.name == "Toaster")
            {
                _spawnedIn4 = true;
            }

            if (other.gameObject.name == "Fish")
            {
                _spawnedIn5 = true;
            }

            if (other.gameObject.name == "FireEx")
            {
                _spawnedIn6 = true;
            }
        }
    }
}
