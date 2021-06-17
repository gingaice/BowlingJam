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


    public int Power;

    // Start is called before the first frame update
    void Start()
    {
        Arrow = gameObject.GetComponent<SpriteRenderer>();

        Arrow.sprite = g0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Power += 25;
        }

        if(Power > 31)
        {
            if (Power < 60)
            {
                Arrow.sprite = g1;
            }
        }

        if (Power > 61)
        {
            if (Power < 90)
            {
                Arrow.sprite = g2;
            }
        }

        if (Power > 91)
        {
            if (Power < 120)
            {
                Arrow.sprite = g3;
            }
        }

        if (Power > 121)
        {
            if (Power < 150)
            {
                Arrow.sprite = g4;
            }
        }

        if (Power > 151)
        {
            if (Power < 180)
            {
                Arrow.sprite = g5;
            }
        }

        if (Power > 180)
        {
            if (Power < 210)
            {
                Arrow.sprite = g6;
            }
        }

        if (Power > 211)
        {
            if (Power < 240)
            {
                Arrow.sprite = g7;
            }
        }
    }
}
