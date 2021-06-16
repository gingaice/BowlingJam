using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int _score = 0;

    public bool _fallen;
    public bool _standing;

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
        }

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
