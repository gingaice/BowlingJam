using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowPower : MonoBehaviour
{


    public SpriteRenderer Arrow;

    public Sprite g1;
    public Sprite g2;
    public Sprite g3;
    public Sprite g4;
    public Sprite g5;
    public Sprite g6;
    public Sprite g7;
    public Sprite g0;




    // Start is called before the first frame update
    void Start()
    {
        Arrow = gameObject.GetComponent<SpriteRenderer>();

        Arrow.sprite = g0;
    }

    // Update is called once per frame
    void Update()
    {


        if(BigFishWeBalin.shootPower > 16)
        {
            if (BigFishWeBalin.shootPower < 30)
            {
                Arrow.sprite = g1;
            }
        }

        if (BigFishWeBalin.shootPower > 31)
        {
            if (BigFishWeBalin.shootPower < 45)
            {
                Arrow.sprite = g2;
            }
        }

        if (BigFishWeBalin.shootPower > 46)
        {
            if (BigFishWeBalin.shootPower < 60)
            {
                Arrow.sprite = g3;
            }
        }

        if (BigFishWeBalin.shootPower > 61)
        {
            if (BigFishWeBalin.shootPower < 90)
            {
                Arrow.sprite = g4;
            }
        }

        if (BigFishWeBalin.shootPower > 91)
        {
            if (BigFishWeBalin.shootPower < 120)
            {
                Arrow.sprite = g5;
            }
        }

        if (BigFishWeBalin.shootPower > 121)
        {
            if (BigFishWeBalin.shootPower < 150)
            {
                Arrow.sprite = g6;
            }
        }

        if (BigFishWeBalin.shootPower > 151)
        {
            if (BigFishWeBalin.shootPower < 180)
            {
                Arrow.sprite = g7;
            }
        }
    }
}
