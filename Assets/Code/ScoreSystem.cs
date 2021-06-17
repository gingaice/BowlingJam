using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int _score = 0;

    public bool _fallen;
    public bool _standing;
    public static bool _reset;

    public static bool SpareChance = false;
    //two per round incase of spare if strike then both go to X
    public Text _countCurrent;

    public Image Strike;

    public Transform under;
    public Transform place;
    public Transform trig;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        Strike.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_fallen == true)
        {
            trig.position = under.position;


        }

        if(_reset == true)
        {
            trig.position = place.position;
            _fallen = false;
            _standing = true;
            Strike.enabled = false;
            _score = 0;
            StopCoroutine(Timer());
        }

        if(_standing == true)
        {
            Strike.enabled = false;

            SpareChance = true;
        }

        //if(SpareChance == true)
        //{
            //ball.position = spawn.position;
        //}


        if(_score >= 10)
        {
            Strike.enabled = true;

            StartCoroutine(Timer());
        }


        _countCurrent.text = _score.ToString();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Pin")
        {
            _standing = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.name == "Pin")
        {
            _fallen = true;

            _score += 1;
        }
            
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        _reset = true;
    }
}