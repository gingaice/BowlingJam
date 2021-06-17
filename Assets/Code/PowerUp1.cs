using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    public GameObject dynamite;

    public Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            playerRb.transform.localScale += new Vector3(20f, 20f, 20f);
        }
    }
}
