using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int _score = 0;

    public bool _fallen;
    public bool _standing;

    public static bool SpareChance = false;
    //two per round incase of spare if strike then both go to X
    public Text _countCurrent;

    public Image Strike;

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
            Destroy(this.gameObject);
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
}
/**
 *     public Text _countCurrent2;
    public Text _countCurrent3;
    public Text _countCurrent4;
    public Text _countCurrent5;
    public Text _countCurrent6;
    public Text _countCurrent7;
    public Text _countCurrent8;
    public Text _countCurrent9;
    public Text _countCurrent10;
    public Text _countCurrent11;
    public Text _countCurrent12;
    public Text _countCurrent13;
    public Text _countCurrent14;
    public Text _countCurrent15;
    public Text _countCurrent16;
    public Text _countCurrent17;
    public Text _countCurrent18;
    public Text _countCurrent19;
    public Text _countCurrent20;

    public Text _countCurrent102;
    public Text _countCurrent202;
    public Text _countCurrent302;
    public Text _countCurrent402;
    public Text _countCurrent502;
    public Text _countCurrent602;
    public Text _countCurrent702;
    public Text _countCurrent802;
    public Text _countCurrent902;
    public Text _countCurrent1002;
    public Text _countCurrent1102;
    public Text _countCurrent1202;
    public Text _countCurrent1302;
    public Text _countCurrent1402;
    public Text _countCurrent1502;
    public Text _countCurrent1602;
    public Text _countCurrent1702;
    public Text _countCurrent1802;
    public Text _countCurrent1902;
    public Text _countCurrent2002;
 * 
_countCurrent2.text = _score.ToString();
_countCurrent3.text = _score.ToString();
_countCurrent4.text = _score.ToString();
_countCurrent5.text = _score.ToString();
_countCurrent6.text = _score.ToString();
_countCurrent7.text = _score.ToString();
_countCurrent8.text = _score.ToString();
_countCurrent9.text = _score.ToString();
_countCurrent10.text = _score.ToString();
_countCurrent11.text = _score.ToString();
_countCurrent12.text = _score.ToString();
_countCurrent13.text = _score.ToString();
_countCurrent14.text = _score.ToString();
_countCurrent15.text = _score.ToString();
_countCurrent16.text = _score.ToString();
_countCurrent17.text = _score.ToString();
_countCurrent18.text = _score.ToString();
_countCurrent19.text = _score.ToString();
_countCurrent20.text = _score.ToString();

_countCurrent102.text = _score.ToString();
_countCurrent202.text = _score.ToString();
_countCurrent302.text = _score.ToString();
_countCurrent402.text = _score.ToString();
_countCurrent502.text = _score.ToString();
_countCurrent602.text = _score.ToString();
_countCurrent702.text = _score.ToString();
_countCurrent802.text = _score.ToString();
_countCurrent902.text = _score.ToString();
_countCurrent1002.text = _score.ToString();
_countCurrent1102.text = _score.ToString();
_countCurrent1202.text = _score.ToString();
_countCurrent1302.text = _score.ToString();
_countCurrent1402.text = _score.ToString();
_countCurrent1502.text = _score.ToString();
_countCurrent1602.text = _score.ToString();
_countCurrent1702.text = _score.ToString();
_countCurrent1802.text = _score.ToString();
_countCurrent1902.text = _score.ToString();
_countCurrent2002.text = _score.ToString();
**/