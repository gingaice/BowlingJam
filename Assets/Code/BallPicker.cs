using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallPicker : MonoBehaviour
{
    public Transform _BowlBall;
    public Transform _Fridge;
    public Transform _Turtle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //StartCoroutine(Ing());
        }
    }
/**
    IEnumerator Ing()
    {
        Random.RandomRange
    }
**/
}
