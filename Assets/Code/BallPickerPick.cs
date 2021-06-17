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
    public Transform under;

    public bool _spawnedIn1 = false;
    public bool _spawnedIn2 = false;
    public bool _spawnedIn3 = false;
    public bool _spawnedIn4 = false;
    public bool _spawnedIn5 = false;
    public bool _spawnedIn6 = false;


    public GameObject Ball;
    public GameObject Fridge;
    public GameObject Toaster;
    public GameObject manLegs;
    public GameObject Fish;
    public GameObject Exting;


    public bool spinNo = false;
    // Start is called before the first frame update
    void Start()
    {
        Ball.SetActive(false);
        Fridge.SetActive(false);
        Toaster.SetActive(false);
        manLegs.SetActive(false);
        Fish.SetActive(false);
        Exting.SetActive(false);
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
            Ball.SetActive(false);
            Fridge.SetActive(false);
            Toaster.SetActive(false);
            manLegs.SetActive(false);
            Fish.SetActive(false);
            Exting.SetActive(false);
        }

        if(spinNo == true)
        {
            if (_spawnedIn1 == true)
            {
                //_BowlBall.position = spawn.position;
                Ball.SetActive(true);
                Fridge.SetActive(false);
                Toaster.SetActive(false);
                manLegs.SetActive(false);
                Fish.SetActive(false);
                Exting.SetActive(false);
                _spawnedIn1 = false;
            }

            if (_spawnedIn2 == true)
            {
                Ball.SetActive(false);
                Fridge.SetActive(true);
                Toaster.SetActive(false);
                manLegs.SetActive(false);
                Fish.SetActive(false);
                Exting.SetActive(false);
                _spawnedIn2 = false;
            }

            if (_spawnedIn3 == true)
            {
                Ball.SetActive(false);
                Fridge.SetActive(false);
                Toaster.SetActive(false);
                manLegs.SetActive(true);
                Fish.SetActive(false);
                Exting.SetActive(false);
                _spawnedIn3 = false;
            }

            if (_spawnedIn4 == true)
            {
                Ball.SetActive(false);
                Fridge.SetActive(false);
                Toaster.SetActive(true);
                manLegs.SetActive(false);
                Fish.SetActive(false);
                Exting.SetActive(false);
                _spawnedIn4 = false;
            }

            if (_spawnedIn5 == true)
            {
                Ball.SetActive(false);
                Fridge.SetActive(false);
                Toaster.SetActive(false);
                manLegs.SetActive(false);
                Fish.SetActive(true);
                Exting.SetActive(false);
                _spawnedIn5 = false;
            }

            if (_spawnedIn6 == true)
            {
                Ball.SetActive(false);
                Fridge.SetActive(false);
                Toaster.SetActive(false);
                manLegs.SetActive(false);
                Fish.SetActive(false);
                Exting.SetActive(true);
                _spawnedIn6 = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

            if (other.name == "BowlinBall")
            {

                    _spawnedIn1 = true;
                
            }

            if (other.name == "Fridge")
            {

                    _spawnedIn2 = true;
                
            }

            if (other.name == "ManLeg")
            {

                    _spawnedIn3 = true;
                
            }

            if (other.name == "Toaster")
            {

                    _spawnedIn4 = true;
                
            }

            if (other.name == "Fish")
            {

                    _spawnedIn5 = true;
                
            }

            if (other.name == "FireEx")
            {

                    _spawnedIn6 = true;
                
            }
        
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.name == "BowlinBall")
        {

            _spawnedIn1 = false;

        }

        if (other.name == "Fridge")
        {

            _spawnedIn2 = false;

        }

        if (other.name == "ManLeg")
        {

            _spawnedIn3 = false;

        }

        if (other.name == "Toaster")
        {

            _spawnedIn4 = false;

        }

        if (other.name == "Fish")
        {

            _spawnedIn5 = false;

        }

        if (other.name == "FireEx")
        {

            _spawnedIn6 = false;

        }

    }
}
