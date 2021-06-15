using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPicker : MonoBehaviour
{
    public Transform _BowlBall;
    public Transform _Fridge;
    public Transform _Turtle;

    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {


        if(isSpinning == true)
        {
            transform.Rotate(0, 0, genSpeed, Space.World);
            genSpeed -= subSpeed;
        }
        if(genSpeed <= 0)
        {
            genSpeed = 0;
            isSpinning = false;
        }
    }

    public void SpinWheel()
    {
        genSpeed = Random.Range(2.0f, 5.0f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }
}
