using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int _score = 0;

    public bool _fallen;

    public Text _countCurrent;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (_fallen == true)
        {
            Destroy(this.gameObject);
        }

        _countCurrent.text = _score.ToString();
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
