using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinReplacement : MonoBehaviour
{
    public bool _reset;

    public bool _spawn;

    public bool skadoosh;

    public GameObject pins;
    public Vector3 SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if(_spawn == true)
        {
            SpawnTime();
        }

        if(_reset == true)
        {
            skadoosh = true;
        }
        else
        {
            skadoosh = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(skadoosh == true)
        {
            if (other.gameObject.CompareTag("pin"))
            {
                Destroy(other.gameObject);
                Debug.Log("bii");
            }
        }
    }

    void SpawnTime()
    {
        Instantiate(pins, SpawnPoint, Quaternion.identity);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(15);
        _reset = true;
        yield return new WaitForSeconds(15);
        _spawn = true;
        _reset = false;
        _spawn = true;
        StartCoroutine(Timer());
    }
}
